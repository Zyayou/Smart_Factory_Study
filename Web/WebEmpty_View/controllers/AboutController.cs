using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_View.controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
