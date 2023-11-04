using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class ImageViewModel
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Drawing { get; set; }
        public string Style { get; set; }
        public string KindofPaint { get; set; }

        public string? Accessory { get; set; }

        public string? Notes { get; set; }

        public  Account? Account { get; set; }
    }
}
