using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_View.controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
