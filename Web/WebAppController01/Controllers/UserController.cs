using Microsoft.AspNetCore.Mvc;

namespace WebAppController01.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
