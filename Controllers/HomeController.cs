using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;
using System.Diagnostics;

namespace StronglyTypedViewASPCore.Controllers
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
            Product product = new Product() 
            {
                Id = 1,
                Name = "Dell Mouse",
                Description = "Dell wireless mouse with usb 3.0",
                Price = 225
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "Dell Keyboard",
                Description = "Dell wireless Keyboard with usb 3.0",
                Price = 1025
            };
            var products = new List<Product>() { product,product2 };
            return View(products);
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
    }
}
