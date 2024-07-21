using BelleMariee.App.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleMariee.App.Service.Models
{
    public class SepetDetay 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }

        public List<SepetDetay> SepeteEkle(List<SepetDetay> sepet, SepetDetay siparis)
        {
            if (sepet.Any(s => s.ProductId == siparis.ProductId))
            {

                foreach (var item in sepet)
                {
                    // aynı ürünü bulup, miktarını sipariş miktarı kadar artırıyoruz.
                    if (item.ProductId == siparis.ProductId)
                    {
                        item.ProductQuantity += siparis.ProductQuantity;
                    }
                }

            }
            else
            {
                //yeni ürün, ilk defa sepete atılacak
                sepet.Add(siparis);
            }

            return sepet;
        }
        public List<SepetDetay> SepettenSil(List<SepetDetay> sepet, int id)
        {
            sepet.RemoveAll(s => s.ProductId == id);
            return sepet;
        }
        public int ToplamAdet(List<SepetDetay> sepet)
        {
            var toplamAdet = sepet.Sum(s => s.ProductQuantity);
            return toplamAdet;
        }
        public decimal ToplamTutar(List<SepetDetay> sepet)
        {
            var toplamTutar = sepet.Sum(s => s.ProductQuantity * s.ProductPrice);
            return toplamTutar;
        }
    }
}
