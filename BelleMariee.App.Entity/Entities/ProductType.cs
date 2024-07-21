using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.Entities
{
	public class ProductType : BaseEntity
	{
		public string Name { get; set; }

		//N-P
		public List<Product> Products { get; set; }
	}
}
