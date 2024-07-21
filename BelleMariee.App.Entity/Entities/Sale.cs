using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Entities
{
	public class Sale : BaseEntity
	{
		public DateTime Date { get; set; }
		public int CustomerId { get; set; }
		public int TotalQuantity { get; set; }
		public decimal TotalPrice { get; set; }

		//N-P
		public List<ProductSaleDetails> ProductSalesDetails { get; set; }
		public Customer Customer { get; set; }
	}
}
