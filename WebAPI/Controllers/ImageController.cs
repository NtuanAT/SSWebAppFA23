using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : Controller
    {
        private readonly ImageRepository _imageRepository;
        public ImageController(ImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        #region Get All Images
        /// <summary>
        /// Get All Image
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllImage")]
        public IActionResult GetAllImage()
        {
            ICollection<ImageViewModel> images = new List<ImageViewModel>();
            try
            {
                foreach (var imageViewModel in _imageRepository.GetAll())
                {
                    ImageViewModel immageViewModel = new ImageViewModel();
                    immageViewModel.Id = imageViewModel.Id;
                    immageViewModel.AccountId = imageViewModel.AccountId;
                    immageViewModel.Drawing = imageViewModel.Drawing;
                    immageViewModel.Style = imageViewModel.Style;
                    immageViewModel.KindofPaint = imageViewModel.KindofPaint;
                    immageViewModel.Accessory = imageViewModel.Accessory;
                    immageViewModel.Notes = imageViewModel.Notes;
                    images.Add(immageViewModel);
                }

				return new JsonResult(new
				{
					status = true,
					message = "Get all image success",
					data = images
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

        #region Get Image by ID
        /// <summary>
        /// Get Image by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetImageById/{id}")]
        public IActionResult GetImageById(Guid id)
        {
            var image = new Image();
            try
            {
               
                image = _imageRepository.Get(x => x.Id == id);
                if (image == null)
                {
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Image not found"
                    });
                }

                var imageViewModel = new ImageViewModel
                {
                    Id = image.Id,
                    AccountId = image.AccountId,
                    Drawing = image.Drawing,
                    Style = image.Style,
                    KindofPaint = image.KindofPaint,
                    Accessory = image.Accessory,
                    Notes = image.Notes,

                };


				return new JsonResult(new
				{
					status = true,
					message = "Get Product by id success",
                    date = imageViewModel
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

        #region Get Image by AccountID
        /// <summary>
        /// Get Image By AccountId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetImageByAccountId/{id}")]
        public IActionResult GetImageByAccountId(Guid id)
        {
            var imageResult = new List<ImageViewModel>();
            try
            {
                var images = _imageRepository.GetList(x => x.AccountId == id);
                foreach (var image in images)
                {
					var imageViewModel = new ImageViewModel
                    {
						Id = image.Id,
						AccountId = image.AccountId,
						Drawing = image.Drawing,
						Style = image.Style,
						KindofPaint = image.KindofPaint,
						Accessory = image.Accessory,
						Notes = image.Notes,

					};
					imageResult.Add(imageViewModel);
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get Image by AccountID success",
                    data = imageResult
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

        #region Add Image
        /// <summary>
        /// Add Image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddImage")]
        public IActionResult AddImage([FromBody] ImageViewModel imageViewModel)
        {
            try
            {
                var image = new Image
                {
                    AccountId = imageViewModel.AccountId,
                    Drawing = imageViewModel.Drawing,
                    Style = imageViewModel.Style,
                    KindofPaint = imageViewModel.KindofPaint,
                    Accessory = imageViewModel.Accessory,
                    Notes = imageViewModel.Notes,

                };
                _imageRepository.Add(image);
                _imageRepository.SaveChanges();
                return new JsonResult(new
                {
                    status = true,
                    message = "Add Image success"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status = true,
                    message = ex.Message
                });
            }
        }
        #endregion

        #region Update Image
        /// <summary>
        /// Update Image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateImage")]
        public IActionResult UpdateImage([FromBody] ImageViewModel imageViewModel)
        {
            try
            {
                var image = new Image
                {
                    Id = (Guid)imageViewModel.Id,
                    AccountId = imageViewModel.AccountId,
                    Drawing = imageViewModel.Drawing,
                    Style = imageViewModel.Style,
                    KindofPaint = imageViewModel.KindofPaint,
                    Accessory = imageViewModel.Accessory,
                    Notes = imageViewModel.Notes,

                };
                _imageRepository.Update(image);
                _imageRepository.SaveChanges();
                return new JsonResult(new
                {
                    status = true,
                    message = "Update image success"
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    status= false,
                    message= ex.Message
                });
            }
        }
        #endregion

        #region Delete Image
        /// <summary>
        /// Delete Image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteImage/{id}")]
        public IActionResult DeleteImage(Guid id)
        {
            try
            {
                _imageRepository.Delete(id);
                _imageRepository.SaveChanges();
                return new JsonResult(new
                {
                    status = true,
                    message = "Delete image success"
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
