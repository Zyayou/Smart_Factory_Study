using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_test.Controllers
{
    public class MyController : Controller
    {
        [Route("Help")]
        public IActionResult Help()
        {
            return View();
        }
    }
}
