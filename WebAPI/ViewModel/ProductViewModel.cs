using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public string? Color { get; set; }
        public decimal Price { get; set; }

        public string? Catagories { get; set; }

        public string? PictureLink { get; set; }
        public ICollection<OrderProductViewModel>? Orders { get; set; }
        public ICollection<InStoreProductViewModel>? InStoreProducts { get; set; }
    }
}
