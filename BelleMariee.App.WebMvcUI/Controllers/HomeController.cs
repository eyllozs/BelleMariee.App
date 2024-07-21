using BelleMariee.App.WebMvcUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BelleMariee.App.WebMvcUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult IadeVeDegisim()
        {
            return View("iadevedegisim");
        }
        public IActionResult Siparis()
        {
            return View("siparis");
        }
        public IActionResult SSS()
        {
            return View("sss");
        }
        public IActionResult KVKK()
        {
            return View("kvkk");
        }
        public IActionResult Gizlilik()
        {
            return View("gizlilik");
        }
        public IActionResult Sartlar()
        {
            return View("sartlar");
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}