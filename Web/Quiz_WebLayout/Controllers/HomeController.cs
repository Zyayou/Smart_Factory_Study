using Microsoft.AspNetCore.Mvc;

namespace Quiz_WebLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Today()
        {
            return View();
        }
    }
}
