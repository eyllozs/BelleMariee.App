using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Entity.ViewModels
{
    public class CustomerLoginViewModel
    {
        [Required(ErrorMessage = "Emailinizi giriniz.")]
        [EmailAddress(ErrorMessage = "Hatalı email girişi.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrenizde hata var.")]
        public string Password { get; set; }
    }
}
