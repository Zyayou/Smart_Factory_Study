using Microsoft.AspNetCore.Mvc;

namespace WebAppEmptyAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
