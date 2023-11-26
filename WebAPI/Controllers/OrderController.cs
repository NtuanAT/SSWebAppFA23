using DataLayer;
using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : Controller
	{
		private readonly OrderRepository _orderRepository;
		private readonly AccountRepository _accountRepository;
		private readonly OrderProductRepository _orderProductRepository;
		private readonly OrderServiceRepository _orderServiceRepository;
		private readonly ServiceRepository _serviceRepository;
		private readonly ProductRepository _productRepository;

		public OrderController(OrderRepository orderRepository,
			AccountRepository accountRepository,
		 OrderProductRepository orderProductRepository,
		  OrderServiceRepository orderServiceRepository,
		  ServiceRepository serviceRepository,
		  ProductRepository productRepository
		  )
		{
			_orderRepository = orderRepository;
			_accountRepository = accountRepository;
			_orderProductRepository = orderProductRepository;
			_orderServiceRepository = orderServiceRepository;
			_serviceRepository = serviceRepository;
			_productRepository = productRepository;
		}

		#region Get All Order
		/// <summary>
		/// Get all product
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("GetAllOrder")]
		[Authorize]
		public IActionResult GetAllOrder()
		{
			try
			{
				var orderEntities = _orderRepository.GetAll();
				var orderViews = new List<OrderViewModel>();
				foreach (var orderEntity in orderEntities)
				{
					var orderViewModel = new OrderViewModel
					{
						Id = orderEntity.Id,
						AccountId = orderEntity.AccountId,
						OrderDate = orderEntity.OrderDate,
						Status = orderEntity.Status
					};

					// Get account
					var account = _accountRepository.Get(x => x.Id == orderEntity.AccountId);
					orderViewModel.Account = new AccountViewModel
					{
						Id = account.Id,
						Username = account.Username,
						Password = account.Password,
						DetailId = account.DetailId,
						Status = account.Status,
						Role = account.Role
					};

					// Get products
					var orderProducts = _orderProductRepository.GetList(x => x.OrderId == orderEntity.Id);
					orderViewModel.Products = new List<OrderProductViewModel>();
					foreach (var orderProduct in orderProducts)
					{
						var product = _productRepository.Get(x => x.Id == orderProduct.ProductId);
						orderViewModel.Products.Add(new OrderProductViewModel
						{
							OrderId = orderProduct.OrderId,
							ProductId = orderProduct.ProductId,
							Quantity = orderProduct.Quantity,
							Product = new ProductViewModel
							{
								Id = product.Id,
								Name = product.Name,
								Brand = product.Brand,
								Color = product.Color,
								Price = product.Price,
								Catagories = product.Catagories,
								PictureLink = product.PictureLink
							}
						});
					}

					// Get services
					var orderServices = _orderServiceRepository.GetList(x => x.OrderId == orderEntity.Id);
					orderViewModel.Services = new List<OrderServiceViewModel>();
					foreach (var orderService in orderServices)
					{
						var service = _serviceRepository.Get(x => x.Id == orderService.ServiceId);
						orderViewModel.Services.Add(new OrderServiceViewModel
						{
							OrderId = orderService.OrderId,
							ServiceId = orderService.ServiceId,
							Quantity = orderService.Quantity,
							Message = orderService.Message,
							Service = new ServiceViewModel
							{
								Id = service.Id,
								Price = service.Price,
								Type = service.Type,
							}
						});
					}
					orderViews.Add(orderViewModel);
				}
				return new JsonResult(new
				{
					status = true,
					message = "Get all orders success",
					data = orderViews
				});

			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Get Order by OrderID
		/// <summary>
		/// Get Order by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetOrderbyOrderID/{id}")]
		public IActionResult GetOrderByOrderID(Guid id)
		{
			try
			{
				var order = _orderRepository.Get(x => x.Id == id);
				if (order == null)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Order not found"
					});
				}
				// Get account
				var account = _accountRepository.Get(x => x.Id == order.AccountId);
				var orderViewModel = new OrderViewModel
				{
					Id = order.Id,
					AccountId = order.AccountId,
					OrderDate = order.OrderDate,
					Status = order.Status,
					Account = new AccountViewModel
					{
						Id = account.Id,
						Username = account.Username,
						Password = account.Password,
						DetailId = account.DetailId,
						Status = account.Status,
						Role = account.Role
					}
				};

				// Get products
				var orderProducts = _orderProductRepository.GetList(x => x.OrderId == order.Id);
				orderViewModel.Products = new List<OrderProductViewModel>();
				foreach (var orderProduct in orderProducts)
				{
					var product = _productRepository.Get(x => x.Id == orderProduct.ProductId);
					orderViewModel.Products.Add(new OrderProductViewModel
					{
						OrderId = orderProduct.OrderId,
						ProductId = orderProduct.ProductId,
						Quantity = orderProduct.Quantity,
						Product = new ProductViewModel
						{
							Id = product.Id,
							Name = product.Name,
							Brand = product.Brand,
							Color = product.Color,
							Price = product.Price,
							Catagories = product.Catagories,
							PictureLink = product.PictureLink
						}
					});
				}

				// Get services
				var orderServices = _orderServiceRepository.GetList(x => x.OrderId == order.Id);
				orderViewModel.Services = new List<OrderServiceViewModel>();
				foreach (var orderService in orderServices)
				{
					var service = _serviceRepository.Get(x => x.Id == orderService.ServiceId);
					orderViewModel.Services.Add(new OrderServiceViewModel
					{
						OrderId = orderService.OrderId,
						ServiceId = orderService.ServiceId,
						Quantity = orderService.Quantity,
						Message = orderService.Message,
						Service = new ServiceViewModel
						{
							Id = service.Id,
							Price = service.Price,
							Type = service.Type,
						}
					});
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get order by ID success",
					data = order
				});
			}

			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Get All Service Order
		/// <summary>
		/// Get Order by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetAllServiceOrder")]
		public IActionResult GetAllServiceOrder()
		{
			try
			{
				var orders = _orderRepository.GetAll()
				.Where(order => _orderServiceRepository.GetList(oss => oss.OrderId == order.Id).Any())
				.ToList();
                var orderViewModels = new List<OrderViewModel>();
                foreach (var order in orders)
				{
					var orderViewModel = new OrderViewModel
					{
						Id = order.Id,
						AccountId = order.AccountId,
						OrderDate = order.OrderDate,
						Status = order.Status
					};

					// Get account
					var account = _accountRepository.Get(x => x.Id == order.AccountId);
					if (account != null)
					{
                        orderViewModel.Account = new AccountViewModel
                        {
                            Id = account.Id,
                            Username = account.Username,
                            Password = account.Password,
                            DetailId = account.DetailId,
                            Status = account.Status,
                            Role = account.Role
                        };
                    }   

					// Get services
					var orderServicesList = _orderServiceRepository.GetList(x => x.OrderId == order.Id);
					orderViewModel.Services = new List<OrderServiceViewModel>();
					foreach (var orderService in orderServicesList)
					{
						var service = _serviceRepository.Get(x => x.Id == orderService.ServiceId);
						if (service != null)
						{
                            orderViewModel.Services.Add(new OrderServiceViewModel
                            {
                                OrderId = orderService.OrderId,
                                ServiceId = orderService.ServiceId,
                                Quantity = orderService.Quantity,
                                Message = orderService.Message,
                                Service = new ServiceViewModel
                                {
                                    Id = service.Id,
                                    Price = service.Price,
                                    Type = service.Type,
                                }
                            });
                        }   
					}
					orderViewModels.Add(orderViewModel);
				}	

				return new JsonResult(new
				{
					status = true,
					message = "Get all service orders success",
					data = orderViewModels
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Get All Product Order
		/// <summary>
		/// Get Order by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetAllProductOrder")]
		public IActionResult GetAllProductOrder()
		{
			try
			{
				var orders = _orderRepository.GetAll()
				.Where(order => _orderProductRepository.GetList(op => op.OrderId == order.Id).Any())
				.ToList();
                var orderViewModels = new List<OrderViewModel>();
                foreach (var order in orders)
				{
					var orderViewModel = new OrderViewModel
					{
						Id = order.Id,
						AccountId = order.AccountId,
						OrderDate = order.OrderDate,
						Status = order.Status
					};

					// Get account
					var account = _accountRepository.Get(x => x.Id == order.AccountId);
					if (account != null)
					{
                        orderViewModel.Account = new AccountViewModel
                        {
                            Id = account.Id,
                            Username = account.Username,
                            Password = account.Password,
                            DetailId = account.DetailId,
                            Status = account.Status,
                            Role = account.Role
                        };
                    }
                        

					// Get products
					var orderProductsList = _orderProductRepository.GetList(x => x.OrderId == order.Id);
					if (orderProductsList != null)
					{
                        orderViewModel.Products = new List<OrderProductViewModel>();
                        foreach (var orderProduct in orderProductsList)
                        {
                            var product = _productRepository.Get(x => x.Id == orderProduct.ProductId);
                            orderViewModel.Products.Add(new OrderProductViewModel
                            {
                                OrderId = orderProduct.OrderId,
                                ProductId = orderProduct.ProductId,
                                Quantity = orderProduct.Quantity,
                                Product = new ProductViewModel
                                {
                                    Id = product.Id,
                                    Name = product.Name,
                                    Brand = product.Brand,
                                    Color = product.Color,
                                    Price = product.Price,
                                    Catagories = product.Catagories,
                                    PictureLink = product.PictureLink
                                }
                            });
                        }
                    }
					orderViewModels.Add(orderViewModel);
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get all product orders success",
					data = orderViewModels
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Get Order by AccountID
		/// <summary>
		/// Get Order By AccountID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetOrderbyAccountID/{id}")]
		public IActionResult GetOrderByAccountID(Guid id)
		{
			try
			{
				// Assuming the generic repository has a method like Get(Expression<Func<TEntity, bool>> filter)
				var orders = _orderRepository.GetList(order => order.AccountId == id);

				if (orders == null || !orders.Any())
				{
					return new JsonResult(new
					{
						status = false,
						message = "No orders found for the specified AccountID"
					});
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get orders by AccountID success",
					data = orders
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Add Product Order
		/// <summary>
		/// Get all product
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("AddProductOrder")]
		[Authorize]
		public IActionResult AddProductOrder([FromBody] List<OrderProductViewModel> items)
		{
			try
			{
				var orderProducts = new List<OrderProduct>();
				decimal total = 0;
				var orderId = Guid.NewGuid();
				foreach (var item in items)
				{
					var product = _productRepository.Get(s => s.Id == item.ProductId);
					decimal totalProductPrice = product.Price * item.Quantity;
					total += totalProductPrice;
					orderProducts.Add(new OrderProduct
					{
						OrderId = orderId,
						ProductId = (Guid)item.ProductId,
						Quantity = item.Quantity
					});
				}
				var order = new Order
				{
					Id = orderId,
					AccountId = Guid.Parse(User.Identity.Name),
					OrderDate = DateTime.Now,
					Total = total
				};
				_orderRepository.Add(order);
				_orderProductRepository.AddRange(orderProducts);

				var result = _orderRepository.SaveChanges();
				if (result == 0)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Add order failed"
					});
				}
				return new JsonResult(new
				{
					status = true,
					message = "Add order success"
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Add Service Order
		/// <summary>
		/// Get all product
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("AddServiceOrder")]
		[Authorize]
		public IActionResult AddServiceOrder([FromBody] List<OrderServiceViewModel> items)
		{
			try
			{
				var orderService = new List<OrderService>();
				decimal total = 0;
				var orderId = Guid.NewGuid();
				foreach (var item in items)
				{
					var service = _serviceRepository.Get(s => s.Id == item.ServiceId);
					if (service != null)
					{
						decimal totalServicePrice = service.Price * item.Quantity;
						total += totalServicePrice;

						orderService.Add(new OrderService
						{
							OrderId = orderId,
							ServiceId = (Guid)item.ServiceId,
							Quantity = item.Quantity,
							Message = item.Message
						}); ;
					}
					else
					{
						// Handle the case when the service with the given ID is not found
						return new JsonResult(new
						{
							status = false,
							message = $"Service with ID {item.ServiceId} not found."
						});
					}
				}
				var order = new Order
				{
					Id = orderId,
					AccountId = Guid.Parse(User.Identity.Name),
					OrderDate = DateTime.Now,
					Total = total
				};
				_orderRepository.Add(order);
				_orderServiceRepository.AddRange(orderService);

				var result = _orderRepository.SaveChanges();
				if (result == 0)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Add service order failed"
					});
				}
				return new JsonResult(new
				{
					status = true,
					message = "Add service order success"
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

		#region Update Order
		/// <summary>
		/// Update Order
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		[HttpPatch]
		[Route("UpdateOrder")]

		public IActionResult UpdateOrder([FromBody] Order order)
		{
			try
			{
				_orderRepository.Update(order);
				_orderRepository.SaveChanges();
				return new JsonResult(new
				{
					status = true,
					message = "Update order success"
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		[HttpPut]
		[Route("ChangeStatus/{status}/{orderId}")]
		public IActionResult ChangeStatus(int status, Guid orderId)
		{
			try
			{
				var order = _orderRepository.Get(x => x.Id == orderId);
				order.Status = (OrderStatus)status;
				_orderRepository.Update(order);
				return new JsonResult(new
				{
					status = true,
					message = "Update order success"
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}


		#endregion

		#region Delete Order
		[HttpDelete]
		[Route("DeleteOrder/{id}")]

		public IActionResult DeleteOrder(Guid id)
		{
			try
			{
				_orderRepository.Delete(id);
				_orderRepository.SaveChanges();
				return new JsonResult(new
				{
					status = true,
					message = "Delete order success"
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					message = ex.Message
				});
			}
		}
		#endregion

	}
}
