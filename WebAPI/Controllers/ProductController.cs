using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductController : Controller
	{
		private readonly ProductRepository _productRepository;
		public ProductController(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		#region Get All Product
		/// <summary>
		/// Get all product
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("GetAllProduct")]

		public IActionResult GetAllProduct()
		{
			ICollection<ProductViewModel> products = new List<ProductViewModel>();
			try
			{

				var result = _productRepository.GetAll();
				foreach (var product in result)
				{
					ProductViewModel productViewModel = new ProductViewModel();
					productViewModel.Id = product.Id;
					productViewModel.Name = product.Name;
					productViewModel.Brand = product.Brand;
					productViewModel.Color = product.Color;
					productViewModel.Price = product.Price;
					productViewModel.Catagories = product.Catagories;
					productViewModel.Size = product.Size;
					productViewModel.PictureLink = product.PictureLink;
					products.Add(productViewModel);

				}

				return new JsonResult(new
				{
					status = true,
					message = "Get all product success",
					data = products
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

		#region Get Product By Id
		/// <summary>
		/// Get product by id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("GetProductById/{id}")]
		public IActionResult GetProductById(Guid id)
		{
			var product = new Product();
			try
			{
				product = _productRepository.Get(x => x.Id == id);
				if (product == null)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Product not found"
					});
				}

				return new JsonResult(new
				{
					status = true,
					message = "Get product by id success",
					data = product
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

		#region Add Product
		/// <summary>
		/// Add product
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("AddProduct")]
		public IActionResult AddProduct([FromBody] ProductViewModel productViewModel)
		{
			try
			{
				var product = new Product
				{
					Name = productViewModel.Name,
					Brand = productViewModel.Brand,
					Color = productViewModel.Color,
					Price = productViewModel.Price,
					Catagories = productViewModel.Catagories,
					Size = productViewModel.Size,
					PictureLink = productViewModel.PictureLink,
				};
				_productRepository.Add(product);
				_productRepository.SaveChanges();
				return new JsonResult(new
				{
					status = true,
					message = "Add product success"
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

		#region Update Product
		/// <summary>
		/// Update product
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		[HttpPatch]
		[Route("UpdateProduct")]
		public IActionResult UpdateProduct([FromBody] ProductViewModel productViewModel)
		{
			try
			{
				var product = new Product
				{
					Id = (Guid)productViewModel.Id,
					Name = productViewModel.Name,
					Brand = productViewModel.Brand,
					Color = productViewModel.Color,
					Price = productViewModel.Price,
					Catagories = productViewModel.Catagories,
					Size = productViewModel.Size,
					PictureLink = productViewModel.PictureLink,
				};
				_productRepository.Update(product);
				_productRepository.SaveChanges();
				return new JsonResult(new
				{
					status = true,
					message = "Update product success"
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

		#region Delete Product
		/// <summary>
		/// Delete product
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete]
		[Route("DeleteProduct/{id}")]
		public IActionResult DeleteProduct(Guid id)
		{
			try
			{
				_productRepository.Delete(id);
				_productRepository.SaveChanges();
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
