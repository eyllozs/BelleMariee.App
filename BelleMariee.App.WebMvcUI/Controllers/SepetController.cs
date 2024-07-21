using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using BelleMariee.App.Service.Models;

namespace BelleMariee.App.WebMvcUI.Controllers
{
    public class SepetController : Controller
    {
        private readonly IProductService _productService;

        public SepetController(IProductService productService)
        {
            _productService = productService;
        }

        List<SepetDetay> sepet;
        SepetDetay siparis = new SepetDetay();

        public IActionResult Index()
        {
            sepet = SepetAl();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);
            if (siparis.ToplamTutar(sepet) > 0)
                TempData["ToplamTutar"] = siparis.ToplamTutar(sepet);

            return View(sepet);
        }

        public async Task<IActionResult> Ekle(int Id, int Adet)
        {
            var product = await _productService.Get(Id);
            sepet = SepetAl();
            SepetDetay siparis = new SepetDetay
            {
                ProductImageUrl = product.ImageUrl,
                ProductId = product.Id,
                ProductName = product.Name,
                ProductQuantity = Adet,
                ProductPrice = product.Price
            };
            sepet = siparis.SepeteEkle(sepet, siparis);
            SepetKaydet(sepet);
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            sepet = SepetAl();
            siparis.SepettenSil(sepet, id);
            SepetKaydet(sepet);
            return RedirectToAction("Index");
        }

        public IActionResult SepetSil()
        {
            //HttpContext.Session.Clear();  //oturumunda bulunan tüm sessionları siler
            HttpContext.Session.Remove("sepet"); //sadece ismi belirtilen session'ı siler
            return RedirectToAction("Index");
        }

        public List<SepetDetay> SepetAl()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();  //tek soru işareti null da olabilir anlamındadır. çift soru işareti null geldiği zaman anlamındaıdr.
            return sepet;
        }

        public void SepetKaydet(List<SepetDetay> sepet)
        {
            HttpContext.Session.SetJson("sepet", sepet);
        }
    }
}
