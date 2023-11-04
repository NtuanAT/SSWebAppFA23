using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class PaymentViewModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string Method { get; set; } = null!;
        public DateTime PaymentDate { get; set; }
        public PaymentStatus Status { get; set; }

        public  Order? Order { get; set; } = null!;
    }
}
