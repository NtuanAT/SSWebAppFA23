using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        private readonly ServiceRepository _serviceRepository;
        public ServiceController(ServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository ;
        }

        #region Get All Services
        /// <summary>
        /// Get all service
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllService")]

        public IActionResult GetAlService()
        {
            ICollection<ServiceViewModel> services = new List<ServiceViewModel>();
            try
            {
                var result = _serviceRepository.GetAll();
                foreach (var service in result)
                {
                    ServiceViewModel model = new ServiceViewModel();
                    model.Id = service.Id;
                    model.Price = service.Price;
                    model.Type = service.Type;
                    services.Add(model);
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
                message = "Get all services success",
                data = services
            }) ;
        }
        #endregion

        #region Get Services By Id
        /// <summary>
        /// Get service by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetServicetById/{id}")]
        public IActionResult GetServicetById(Guid id)
        {
            var service = new Service();
            try
            {
                service = _serviceRepository.Get(x => x.Id == id);
                if (service == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Service not found"
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
                message = "Get Service by id success",
                data = service
            });
        }
        #endregion

        #region Add Service
        /// <summary>
        /// Add serice
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddService")]
        public IActionResult AddService([FromBody] ServiceViewModel serviceViewModel)
        {
            try
            {
                var services = new Service
                {
                    Id = serviceViewModel.Id,
                    Price = serviceViewModel.Price,
                    Type = serviceViewModel.Type,
                };
                _serviceRepository.Add(services);
                return new JsonResult(new
                {
                    status = true,
                    message = "Add service success"
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

        #region Update Service
        /// <summary>
        /// Update service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpPatch]
        [Route("UpdateService")]
        public IActionResult UpdateService([FromBody] ServiceViewModel serviceViewModel)
        {
            try
            {
                var service = new Service
                {
                    Id = serviceViewModel.Id,
                    Price = serviceViewModel.Price,
                    Type = serviceViewModel.Type,
                };
                _serviceRepository.Update(service);
                return new JsonResult(new
                {
                    status = true,
                    message = "Update service success"
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

        #region Delete Service
        /// <summary>
        /// Delete service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteService/{id}")]
        public IActionResult DeleteService(Guid id)
        {
            try
            {
                _serviceRepository.Delete(id);
                return new JsonResult(new
                {
                    status = true,
                    message = "Delete service success"
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
