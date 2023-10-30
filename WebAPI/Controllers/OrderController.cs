using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : Controller
	{
		private readonly OrderRepository _orderRepository;
		private	readonly OrderProductRepository _orderProductRepository;
		private readonly OrderServiceRepository _orderServiceRepository;

		public OrderController(OrderRepository orderRepository, OrderProductRepository orderProductRepository, OrderServiceRepository orderServiceRepository)
        {
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _orderServiceRepository = orderServiceRepository;
        }

        #region Get All Order
        /// <summary>
        /// Get all product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
		[Route("GetAllOrder")]

		public IActionResult GetAllOrder()
		{
			ICollection<Order> orders = new List<Order>();
			try
			{
				orders = _orderRepository.GetAll();
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
				data = orders
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

		public IActionResult AddOrder([FromBody] Order order)
		{
			try
			{
				var createdOrder = _orderRepository.Add(order);
				foreach(OrderProduct product in order.Products)
				{
					product.OrderId = createdOrder.Id;
					_orderProductRepository.Add(product);
				}
				foreach(OrderService service in order.Services)
				{
					service.OrderId = createdOrder.Id;
					_orderServiceRepository.Add(service);
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

		#region Update Order
		[HttpPatch]
		[Route("UpdateOrder")]

		public IActionResult UpdateOrder([FromBody] Order order)
		{
			try
			{
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
