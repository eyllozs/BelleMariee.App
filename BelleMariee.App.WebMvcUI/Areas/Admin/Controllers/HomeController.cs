using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using AutoMapper;
using System.Threading.Tasks;
using BelleMariee.App.WebMvcUI.Models;
using Microsoft.EntityFrameworkCore;
using BelleMariee.App.DataAccess.Contexts;

namespace BelleMariee.App.WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;
        private readonly BelleDbContext _context;

        public HomeController(IProductService productService, ICategoryService categoryService, IProductTypeService productTypeService, IMapper mapper, BelleDbContext context)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productTypeService = productTypeService;
            _mapper = mapper;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAll();
            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");
            ViewBag.ProductTypes = new SelectList(await _productTypeService.GetAll(), "Id", "Name");

            var viewModel = new ProductViewModel();

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {

                await _productService.Add(product);
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");
            ViewBag.ProductTypes = new SelectList(await _productTypeService.GetAll(), "Id", "Name");
            return View(product);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

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

            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");
            ViewBag.ProductTypes = new SelectList(await _productTypeService.GetAll(), "Id", "Name");

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {

                await _productService.Update(product);
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");
            ViewBag.ProductTypes = new SelectList(await _productTypeService.GetAll(), "Id", "Name");
            return View(product);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Delete(ProductViewModel model)
        {
            var product = await _context.Products.FindAsync(model.Id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }







    }
}
