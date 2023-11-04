using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class FeedbackViewModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }

        public string? Comment { get; set; }

        public int? Rate { get; set; }

        public string? Picture { get; set; }

        public  Order? Order { get; set; } = null!;
    }
}
