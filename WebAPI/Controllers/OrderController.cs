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
		private readonly PaymentRepository _paymentRepository;
		private readonly FeedbackRepository _feedbackRepository;
		private readonly InStoreProductRepository _inStoreProductRepository;

		public OrderController(OrderRepository orderRepository,
			AccountRepository accountRepository,
			OrderProductRepository orderProductRepository,
			OrderServiceRepository orderServiceRepository,
			ServiceRepository serviceRepository,
			ProductRepository productRepository,
			PaymentRepository paymentRepository,
			FeedbackRepository feedbackRepository,
			InStoreProductRepository inStoreProductRepository)
		{
			_orderRepository = orderRepository;
			_accountRepository = accountRepository;
			_orderProductRepository = orderProductRepository;
			_orderServiceRepository = orderServiceRepository;
			_serviceRepository = serviceRepository;
			_productRepository = productRepository;
			_paymentRepository = paymentRepository;
			_feedbackRepository = feedbackRepository;
			_inStoreProductRepository = inStoreProductRepository;
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
							Size = orderProduct.Size,
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

					// Get payment
					var payment = _paymentRepository.Get(x => x.OrderId == orderEntity.Id);
					if (payment != null)
					{
						orderViewModel.Payment = new PaymentViewModel
						{
							Id = payment.Id,
							OrderId = payment.OrderId,
							Method = payment.Method,
							PaymentDate = payment.PaymentDate,
							Status = payment.Status
						};
					}

					// Get feedback
					var feedback = _feedbackRepository.Get(x => x.OrderId == orderEntity.Id);
					if (feedback != null)
					{
						orderViewModel.Feedback = new FeedbackViewModel
						{
							Id = feedback.Id,
							OrderId = feedback.OrderId,
							Comment = feedback.Comment,
							Picture = feedback.Picture,
							Rate = feedback.Rate
						};
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
						Size = orderProduct.Size,
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
								Size = orderProduct.Size,
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

				var result = new List<OrderViewModel>();
				foreach (var order in orders)
				{
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
					result.Add(orderViewModel);
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get orders by AccountID success",
					data = result
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
						Size = item.Size,
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
		[Authorize]
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

		/// <summary>
		/// Change status of order
		/// </summary>
		/// <param name="status"></param>
		/// <param name="orderId"></param>
		/// <returns></returns>
		[HttpPut]
		[Route("ChangeStatus/{status}/{orderId}")]
		[Authorize]
		public IActionResult ChangeStatus(int status, Guid orderId)
		{
			try
			{
				var order = _orderRepository.Get(x => x.Id == orderId);

				if (order == null)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Order not found"
					});
				}

				// Get products
				var orderProducts = _orderProductRepository.GetList(x => x.OrderId == order.Id);
				order.Products = new List<OrderProduct>();
				foreach (var orderProduct in orderProducts)
				{
					var product = _productRepository.Get(x => x.Id == orderProduct.ProductId);
					order.Products.Add(new OrderProduct
					{
						OrderId = orderProduct.OrderId,
						ProductId = orderProduct.ProductId,
						Quantity = orderProduct.Quantity,
						Size = orderProduct.Size,
						Product = new Product
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
				order.Services = new List<OrderService>();
				foreach (var orderService in orderServices)
				{
					var service = _serviceRepository.Get(x => x.Id == orderService.ServiceId);
					order.Services.Add(new OrderService
					{
						OrderId = orderService.OrderId,
						ServiceId = orderService.ServiceId,
						Quantity = orderService.Quantity,
						Message = orderService.Message,
						Service = new Service
						{
							Id = service.Id,
							Price = service.Price,
							Type = service.Type,
						}
					});
				}

				// Get payment
				var payment = _paymentRepository.Get(x => x.OrderId == order.Id);
				if (payment != null)
				{
					order.Payment = new Payment
					{
						Id = payment.Id,
						OrderId = payment.OrderId,
						Method = payment.Method,
						PaymentDate = payment.PaymentDate,
						Status = payment.Status
					};
				}

				// Get feedback
				var feedback = _feedbackRepository.Get(x => x.OrderId == order.Id);
				if (feedback != null)
				{
					order.FeedBack = new FeedBack
					{
						Id = feedback.Id,
						OrderId = feedback.OrderId,
						Comment = feedback.Comment,
						Picture = feedback.Picture,
						Rate = feedback.Rate
					};
				}

				// Check if status is delivered 
				var parsedStatus = Enum.Parse(typeof(OrderStatus), status.ToString());
				if (parsedStatus.Equals(OrderStatus.Delivered))
				{
					// Check if order has been paid
					if (order.Payment == null)
					{
						return new JsonResult(new
						{
							status = false,
							message = "Order has not been paid"
						});
					}

					// Check if order has been delivered
					if (order.Status == OrderStatus.Delivered)
					{
						return new JsonResult(new
						{
							status = false,
							message = "Order has been delivered"
						});
					}

					// Check if order has been cancelled
					if (order.Status == OrderStatus.Cancelled)
					{
						return new JsonResult(new
						{
							status = false,
							message = "Order has been cancelled"
						});
					}

					// Check if order has been processed or delivering
					if (order.Status != OrderStatus.Processing && order.Status != OrderStatus.Delivering)
					{
						return new JsonResult(new
						{
							status = false,
							message = "Order has not been processed or delivering"
						});
					}

					//// Update in store product quantity
					//foreach (var orderProduct in order.Products)
					//{
					//	var inStoreProduct = _inStoreProductRepository.Get(x => x.ProductId == orderProduct.ProductId && x.Size == orderProduct.Size);
					//	if (inStoreProduct != null)
					//	{
					//		inStoreProduct.Quantity -= orderProduct.Quantity;
					//		if (inStoreProduct.Quantity < 0)
					//		{
					//			return new JsonResult(new
					//			{
					//				status = false,
					//				message = "Not enough product in store"
					//			});
					//		}
					//		_inStoreProductRepository.Update(inStoreProduct);
					//	}
					//}
				}
				order.Status = (OrderStatus)parsedStatus;

				_orderRepository.ClearTrackers();
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
