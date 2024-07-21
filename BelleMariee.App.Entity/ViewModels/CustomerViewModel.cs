using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

		[Required(ErrorMessage = "İsim alanı boş geçilemez.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email alanı boş geçilemez")]
		[EmailAddress(ErrorMessage = "Email formatına uygun değil")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifrenizde hata var.")]
		public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
