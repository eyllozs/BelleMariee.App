using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Entities
{
	public class ProductSaleDetails : BaseEntity
	{
		public int SaleId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }

		//N-P
		public Sale ProductSale { get; set; }
		public Product Product { get; set; }
        public string ImageUrl { get; set; }
    }
}
