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
		private readonly InStoreProductRepository _inStoreProductRepository;
		public ProductController(ProductRepository productRepository, InStoreProductRepository inStoreProductRepository)
		{
			_productRepository = productRepository;
			_inStoreProductRepository = inStoreProductRepository;
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
					productViewModel.PictureLink = product.PictureLink;

					var inStoreProduct = _inStoreProductRepository.GetList(x => x.ProductId == product.Id);
					productViewModel.InStoreProducts = new List<InStoreProductViewModel>();
					foreach (var item in inStoreProduct)
					{
						productViewModel.InStoreProducts.Add(new InStoreProductViewModel
						{
							Id = item.Id,
							ProductId = item.ProductId,
							Quantity = item.Quantity,
							Size = item.Size,
						});
					}
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
				// Get product
				product = _productRepository.Get(p => p.Id == id);
				if (product == null)
				{
					return new JsonResult(new
					{
						status = false,
						message = "Product not found"
					});
				}

				// Get in store product
				var inStoreProduct = _inStoreProductRepository.GetList(x => x.ProductId == product.Id);
				product.InStoreProducts = new List<InStoreProduct>();
				foreach (var item in inStoreProduct)
				{
					product.InStoreProducts.Add(new InStoreProduct
					{
						Id = item.Id,
						ProductId = item.ProductId,
						Quantity = item.Quantity,
						Size = item.Size,
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
					PictureLink = productViewModel.PictureLink,
				};
				var addedProduct = _productRepository.Add(product);

				// Add in store product
				foreach (var item in productViewModel.InStoreProducts)
				{
					var inStoreProduct = new InStoreProduct
					{
						ProductId = addedProduct.Id,
						Quantity = item.Quantity,
						Size = item.Size,
					};
					_inStoreProductRepository.Add(inStoreProduct);
				}
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
		[Route("UpdateProduct/{id}")]
		public IActionResult UpdateProduct([FromBody] ProductViewModel productViewModel)
		{
			try
			{
				var existingProduct = _productRepository.Get(p => p.Id == productViewModel.Id);
				if (existingProduct == null) 
				{
                    return new JsonResult(new
                    {
                        status = false,
                        message = "Product not found"
                    });
                }
				existingProduct.Name = productViewModel.Name;
				existingProduct.Brand = productViewModel.Brand;
				existingProduct.Color = productViewModel.Color;
				existingProduct.Price = productViewModel.Price;
				existingProduct.Catagories = productViewModel.Catagories;
				existingProduct.PictureLink	= productViewModel.PictureLink;
				_productRepository.Update(existingProduct);
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
