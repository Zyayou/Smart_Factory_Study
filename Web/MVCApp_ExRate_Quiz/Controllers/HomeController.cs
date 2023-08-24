using Microsoft.AspNetCore.Mvc;
using MVCApp_ExRate_Quiz.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace MVCApp_ExRate_Quiz.Controllers
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
        [HttpPost]
        public IActionResult Index(double Won)
        {
            ViewBag.Dollar = Won * 0.00075;
            ViewBag.Euro = Won * 0.00069;
            ViewBag.yen = Won * 0.11;
            ViewBag.yuan = Won * 0.0054;

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