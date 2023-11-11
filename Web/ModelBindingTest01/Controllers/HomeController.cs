using Microsoft.AspNetCore.Mvc;
using ModelBindingTest01.Models;
using System.Diagnostics;

namespace ModelBindingTest01.Controllers
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
        /*
        [HttpPost]
        public string Index(Student st)
        {

            return "Id : " + st.Id + " 이름 : " + st.Name + " 전화번호 : " + st.Hp;
        }
        */
        
        [HttpPost]
        public string Index(Board bd)
        {

            return "NO : " + bd.No + " 제목 : " + bd.Title + " 내용 : " + bd.Content + " 작성자 : " + bd.Author + " 작성날짜 : "+ bd.WriteTime;
        }
        
        public string About(Student st)
        {
            return "Id : " + st.Id + " 이름 : " + st.Name + " 전화번호 : " + st.Hp;
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