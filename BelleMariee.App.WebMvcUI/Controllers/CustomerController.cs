using AutoMapper;
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.Entity.Entities;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using BelleMariee.App.Service.Interfaces;
using BelleMariee.App.Service.Models;
using BelleMariee.App.WebMvcUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CustomerController : Controller
{
    private readonly ICustomerService _customerService;
    private readonly ISaleService _saleService;
    private readonly IProductSaleDetailsService _productSaleDetailsService;
    private readonly IMapper _mapper;
    private readonly BelleDbContext _context;

    public CustomerController(ICustomerService customerService, IMapper mapper, ISaleService saleService, IProductSaleDetailsService productSaleDetailsService, BelleDbContext context)
    {
        _customerService = customerService;
        _mapper = mapper;
        _saleService = saleService;
        _productSaleDetailsService = productSaleDetailsService;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var customers = await _customerService.GetAll();
        var customerViewModels = _mapper.Map<IEnumerable<CustomerViewModel>>(customers);
        return View(customerViewModels);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(CustomerLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var customer = await _customerService.GetByEmailAndPassword(model.Email, model.Password);
            if (customer == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
            }
            else
            {
                HttpContext.Session.SetJson("user", customer);
                return RedirectToAction("ConfirmAddress");
            }
        }

        return View(model);
    }

    public async Task<IActionResult> ConfirmAddress()
    {
        var customer = HttpContext.Session.GetJson<Customer>("user");
        if (customer == null)
        {
            return RedirectToAction("Login");
        }

        return View(_mapper.Map<CustomerViewModel>(customer));
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmAddress(CustomerViewModel model)
    {
        var customer = HttpContext.Session.GetJson<Customer>("user");
        if (customer == null)
        {
            return RedirectToAction("Login");
        }

        // Ensure that the password is not overwritten with a null value
        var updatedCustomer = _mapper.Map<Customer>(model);
        updatedCustomer.Id = customer.Id;
        updatedCustomer.Password = customer.Password; // Preserve the existing password

        await _customerService.Update(updatedCustomer);
        HttpContext.Session.SetJson("user", updatedCustomer);

        

        return RedirectToAction("ConfirmPayment");
    }


    public async Task<IActionResult> ConfirmPayment()
    {
        var customer = HttpContext.Session.GetJson<Customer>("user");
        if (customer == null)
        {
            return RedirectToAction("Login");
        }


        var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet");
        SepetDetay sd = new SepetDetay();
        int toplamAdet = sd.ToplamAdet(sepet);
        decimal toplamTutar = sd.ToplamTutar(sepet);

        SaleViewModel saleViewModel = new SaleViewModel
        {
            CustomerId = customer.Id,
            Date = DateTime.Now,
            TotalQuantity = toplamAdet,
            TotalPrice = toplamTutar
        };

        CustomerFaturaViewModel customerFaturaViewModel = new CustomerFaturaViewModel
        {
            customerViewModel = _mapper.Map<CustomerViewModel>(customer),
            satisViewModel = saleViewModel,
            sepetDetayListesi = sepet
        };

        return View(customerFaturaViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmPay(CustomerFaturaViewModel model)
    {
        var customer = HttpContext.Session.GetJson<Customer>("user");
        if (customer == null)
        {
            return RedirectToAction("Login");
        }

        var existingCustomer = await _customerService.GetById(customer.Id);
        if (existingCustomer == null)
        {
            
            return RedirectToAction("Login");
        }

        var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet");
        SepetDetay sd = new SepetDetay();
        int toplamAdet = sd.ToplamAdet(sepet);
        decimal toplamTutar = sd.ToplamTutar(sepet);

        SaleViewModel saleViewModel = new SaleViewModel
        {
            CustomerId = customer.Id,
            Date = DateTime.Now,
            TotalQuantity = toplamAdet,
            TotalPrice = toplamTutar
        };

        var satisId = await _saleService.AddSale(saleViewModel);

        var random = new Random();
        var randomCode = random.Next(100000, 999999).ToString();

        if (await _productSaleDetailsService.AddRange(sepet, satisId))
        {
            TempData["mesaj"] = "Satış işlemi başarıyla tamamlandı.";
            HttpContext.Session.Remove("sepet");
        }
        else
        {
            TempData["mesaj"] = $"Satış işlemi başarılı. Sipariş Kod: {randomCode}";
        }

        return View("MessageShow");
    }

    public async Task<IActionResult> Create(CustomerViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Check if the customer already exists
            var existingCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == model.Email);
            if (existingCustomer != null)
            {
                ModelState.AddModelError("Email", "Customer with this email already exists.");
                return View(model);
            }

            var customer = _mapper.Map<Customer>(model);
            // Ensure the password is not null
            if (string.IsNullOrEmpty(customer.Password))
            {
                ModelState.AddModelError("Password", "Password cannot be empty.");
                return View(model);
            }

            await _customerService.Create(customer);
            return RedirectToAction("Index");
        }
        return View(model);
    }


}
