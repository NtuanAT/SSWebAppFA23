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
        private readonly SswdatabaseContext _context;

        public OrderController(OrderRepository orderRepository,
            AccountRepository accountRepository,
         OrderProductRepository orderProductRepository,
          OrderServiceRepository orderServiceRepository,
          ServiceRepository serviceRepository,
          SswdatabaseContext context
          )
        {
            _orderRepository = orderRepository;
            _accountRepository = accountRepository;
            _orderProductRepository = orderProductRepository;
            _orderServiceRepository = orderServiceRepository;
            _serviceRepository = serviceRepository;
            _context = context;
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
            var orderViews = new List<OrderViewModel>();
            try
            {
                orderViews = _context.Orders
                .Select(x => new OrderViewModel()
                {
                    AccountId = x.AccountId,
                    Id = x.Id,
                    OrderDate = x.OrderDate,
                    Status = x.Status,
                    //AccountName = _context.Accounts.Where(y => y.Id == x.AccountId).Select(y => y.Username).FirstOrDefault(),
                    Products = _context.OderProducts.Where(y => y.OrderId == x.Id)
                    .Select(y => new OrderServiceViewModel()
                    {
                        ProductId = y.ProductId,
                        Quantity = y.Quantity,
                    }).ToList()
                    .ToList(),
                }).ToList();

            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
            return new JsonResult(new
            {
                status = true,
                message = "Get all orders success",
                data = orderViews
            });
        }
        #endregion

        #region Get Order by ID
        /// <summary>
        /// Get Order by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrderbyID/{id}")]
        public IActionResult GetOrderByID(Guid id)
        {
            var order = new Order();
            try
            {
                order = _orderRepository.Get(x => x.Id == id);
                if (order == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Order not found"
                    });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
            return new JsonResult(new
            {
                status = true,
                message = "Get order by ID success",
                data = order
            });
        }
        #endregion

        #region Add Order
        /// <summary>
        /// Get all product
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddOrder")]
        [Authorize]
        public IActionResult AddOrder([FromBody] List<OrderServiceViewModel> items)
        {
            try
            {
                var orderProducts = new List<OrderProduct>();
                int total = 0;
                var orderId = Guid.NewGuid();
                foreach (var item in items)
                {
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
                    Total = items.Count,
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
        public IActionResult AddServiceOrder([FromBody] List<OrderServicesViewModel> items)
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
                            Quantity= item.Quantity
                        });;
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
            var order = new Order();
            try
            {
                order = _orderRepository.Get(x => x.AccountId == id);
                if (order == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Order not found"
                    });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = false,
                    message = ex.Message
                });
            }
            return new JsonResult(new
            {
                status = true,
                message = "Get order by AccountID success",
                data = order
            });
        }
        #endregion
    }
}
