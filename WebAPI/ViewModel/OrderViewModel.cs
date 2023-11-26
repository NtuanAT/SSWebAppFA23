using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace WebAPI.ViewModel
{
    public class OrderViewModel
    {
        public Guid? Id { get; set; }
        public Guid AccountId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus? Status { get; set; }

        public AccountViewModel? Account { get; set; }

        public ICollection<OrderProductViewModel>? Products { get; set; }

        public ICollection<OrderServiceViewModel>? Services { get; set; }

    }

    public class OrderProductViewModel
    {
        public Guid? OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }
        public ProductViewModel? Product { get; set; }
    }

    public class OrderServiceViewModel
    {
        public Guid? OrderId { get; set; }
        public Guid ServiceId { get; set; }
        public int Quantity { get; set; }
        public string? Message { get; set; }
        public ServiceViewModel? Service { get; set; }
    }

}