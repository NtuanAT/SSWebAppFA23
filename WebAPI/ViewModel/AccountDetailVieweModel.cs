using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class AccountDetailVieweModel
    {  
        public Guid Id { get; set; }
      
        public Guid AccountId { get; set; }

        public string? Avatar { get; set; }
       
        public string Fullname { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }
  
        public bool Gender { get; set; }

        public Account? Account { get; set; }
    }
}
