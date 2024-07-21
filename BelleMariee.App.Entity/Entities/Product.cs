using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string? Size { get; set; }
		public int CategoryId { get; set; }
		public int ProductTypeId { get; set; }
		public int UserId { get; set; }

		//NP

		public Category Category { get; set; }
		public List<ProductSaleDetails> ProductSalesDetails { get; set; }
	}
}
