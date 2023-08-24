using Microsoft.AspNetCore.Mvc;

namespace WebAppController01.Controllers
{
    [Route("[controller]")]
    //[Route("Home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Details/{id?}")]
        public int Deails(int id)
        {
            return id;
        }
    }
}
