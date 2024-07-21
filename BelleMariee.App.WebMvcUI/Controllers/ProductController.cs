using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using BelleMariee.App.Service.Models;


namespace BelleMariee.App.WebMvcUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        SepetDetay siparis = new SepetDetay();
        public ProductController(IProductService productRepo)
        {
            _productService = productRepo;
            
        }
        public async Task<IActionResult> Index(int? id, string? search)
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();  //tek soru işareti null da olabilir anlamındadır. çift soru işareti null geldiği zaman anlamındaıdr.
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);

            var products = await _productService.GetAll();

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            return View(products);
        }

        public async Task<IActionResult> Gow()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();  //tek soru işareti null da olabilir anlamındadır. çift soru işareti null geldiği zaman anlamındaıdr.
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);

            var products = await _productService.GetAll();
            products = products.Where(p => p.ProductTypeId == 1).ToList();
            return View(products);
        }
        public async Task<IActionResult> Accessory()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();  //tek soru işareti null da olabilir anlamındadır. çift soru işareti null geldiği zaman anlamındaıdr.
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);

            var products = await _productService.GetAll();
            products = products.Where(p => p.ProductTypeId == 2).ToList();
            return View(products);
        }

        public async Task<IActionResult> Shoe()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();  //tek soru işareti null da olabilir anlamındadır. çift soru işareti null geldiği zaman anlamındaıdr.
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet);

            var products = await _productService.GetAll();
            products= products.Where(p => p.ProductTypeId == 3).ToList();
            return View(products);
        }
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // Mevcut bedenleri kategori ve ürün türüne göre getiriyoruz
            var availableSizes = await _productService.GetAvailableSizes(product.CategoryId, product.ProductTypeId);

            var viewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageUrl = product.ImageUrl,
                ImageUrl2 = product.ImageUrl2,
                ImageUrl3 = product.ImageUrl3,
                Size = product.Size,
                CategoryId = product.CategoryId,
                ProductTypeId = product.ProductTypeId
            };

            ViewBag.AvailableSizes = availableSizes; // Mevcut bedenleri ViewBag ile taşıyoruz

            return View(viewModel);
        }

        public async Task<IActionResult> OzelDikim()
        {
            return View();
        }
    }
    }
