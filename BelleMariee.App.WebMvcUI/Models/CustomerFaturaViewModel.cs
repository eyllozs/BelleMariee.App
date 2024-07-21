using BelleMariee.App.Entity.Entities;using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.WebMvcUI.Models
{
    public class CustomerFaturaViewModel
    {
        public CustomerViewModel customerViewModel { get; set; }
        public SaleViewModel satisViewModel { get; set; }
        public List<SepetDetay> sepetDetayListesi { get; set; }
    }
}
