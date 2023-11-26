using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class AccountViewModel
    {
        public Guid? Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountRole Role { get; set; }
        public AccountStatus Status { get; set; }
        public Guid? DetailId { get; set; }

        public AccountDetailViewModel? AccountDetail { get; set; }

        public ICollection<ImageViewModel>? Images { get; set; }

        public ICollection<OrderViewModel>? Orders { get; set; }
    }
}
