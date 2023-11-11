using Microsoft.AspNetCore.Mvc;
using MVC_Snail.Models;
using System.Diagnostics;

namespace MVC_Snail.Controllers
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
            number num = new number() { N=0 };
            return View(num);
        }
        [HttpPost]
        public IActionResult Index(number num)
        {
            return View(num);
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