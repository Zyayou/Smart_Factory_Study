using Microsoft.AspNetCore.Mvc;
using MVC_Model3.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MVC_Model3.Controllers
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
            var Cars = new List<Car>
            {
                new Car { Id = 1, Brand = "페라리", Speed = 250},
                new Car { Id = 2, Brand = "아반떼", Speed = 200},
                new Car { Id = 3, Brand = "벤츠", Speed = 220}
            };

            ViewData["data1"] = Cars;

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
    }
}