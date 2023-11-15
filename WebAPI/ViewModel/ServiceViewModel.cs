using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class ServiceViewModel
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; } = null!;

        public  ICollection<OrderServiceViewModel>? Orders { get; set; }
    }
}
