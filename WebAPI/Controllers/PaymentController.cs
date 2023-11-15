using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PaymentController : Controller
	{
		private readonly PaymentRepository _paymentRepository;
		public PaymentController(PaymentRepository paymentRepository)
		{
			_paymentRepository = paymentRepository;
		}

		#region Get All Payment
		/// <summary>
		/// Get all payment
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("GetAllPayment")]

		public IActionResult GetAllPayment()
		{
			ICollection<PaymentViewModel> paymentviewmodel = new List<PaymentViewModel>();
			try
			{
				var result = _paymentRepository.GetAll();
				foreach (var item in result)
				{
					PaymentViewModel model = new PaymentViewModel();
					model.OrderId = item.OrderId;
					model.Id = item.Id;
					model.Method = item.Method;
					model.PaymentDate = item.PaymentDate;
					model.Status = item.Status;
					paymentviewmodel.Add(model);

				}

				return new JsonResult(new
				{
					status = true,
					message = "Get All payment success",
					data = paymentviewmodel
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

		#region Get Payment by Id
		/// <summary>
		/// Get Payment by Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetPaymentbyId")]
		public IActionResult GetPaymentbyId(Guid id)
		{
			var payment = new Payment();
			try
			{
				payment = _paymentRepository.Get(x => x.Id == id);
				if (payment == null)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Payment not found"
					});
				}
				var paymentviewmodel = new PaymentViewModel
				{
					OrderId = payment.OrderId,
					Id = payment.Id,
					Method = payment.Method,
					PaymentDate = payment.PaymentDate,
					Status = payment.Status,
				};

				return new JsonResult(new
				{
					status = true,
					message = "Get payment by id success",
					data = paymentviewmodel
				});
			}
			catch (Exception ex)
			{
				return new JsonResult(new
				{
					status = false,
					Message = ex.Message
				});
			}
		}
		#endregion

		#region Add Payment
		/// <summary>
		/// Add Payment
		/// </summary>
		/// <param name="payment"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("AddPayment")]

		public IActionResult AddPayment([FromBody] PaymentViewModel paymentViewModel)
		{
			try
			{
				var payment = new Payment
				{
					OrderId = paymentViewModel.OrderId,
					Method = paymentViewModel.Method,
					PaymentDate = paymentViewModel.PaymentDate,
					Status = paymentViewModel.Status,
				};
				_paymentRepository.Add(payment);
				_paymentRepository.SaveChanges();
				return new JsonResult(new
				{
					status = true,
					message = "Add payment success"
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

		#region Update Payment
		/// <summary>
		/// Update Payment
		/// </summary>
		/// <param name="payment"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("UpdatePayment")]
		public IActionResult UpdatePayment([FromBody] PaymentViewModel paymentviewmodel)
		{
			try
			{
				var payment = new Payment
				{
					Id = (Guid)paymentviewmodel.Id,
					OrderId = paymentviewmodel.OrderId,
					Method = paymentviewmodel.Method,
					PaymentDate = paymentviewmodel.PaymentDate,
					Status = paymentviewmodel.Status,
				};
				_paymentRepository.Update(payment);
				_paymentRepository.SaveChanges();

				return new JsonResult(new
				{
					status = true,
					message = "Update Payment succes"
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

		#region Delete Payment
		/// <summary>
		/// Delete Payment
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("DeletePayment/{id}")]

		public IActionResult DeletePayment(Guid id)
		{
			try
			{
				_paymentRepository.Delete(id);
				return new JsonResult(new
				{
					status = true,
					message = "Delete product success"
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
