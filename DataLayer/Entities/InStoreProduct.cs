using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
	public class InStoreProduct
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public Guid ProductId { get; set; }
		[Required]
		public int Size { get; set; }
		[Required]
		public int Quantity { get; set; }

		public virtual Product? Product { get; set; }
	}
}
