using DataLayer.Entities;

namespace WebAPI.ViewModel
{
	public class InStoreProductViewModel
	{
		public Guid Id { get; set; }
		public Guid ProductId { get; set; }
		public int Size { get; set; }
		public int Quantity { get; set; }

		public ProductViewModel? Product { get; set; }
	}
}
