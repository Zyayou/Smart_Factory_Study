using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_test.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
