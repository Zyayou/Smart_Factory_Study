using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_CRUDTest.Models;
using System.Diagnostics;

namespace MVC_CRUDTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDB;

        public HomeController(StudentDbContext studentDB)
        {
            this.studentDB = studentDB;
        }

        public IActionResult Index()
        {
            var stdData = studentDB.Student.ToList();
            return View(stdData);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // GET: 삽입화면
        public IActionResult Create()
        {
            return View();
        }
        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Hp")] Student student)
        {
            if (ModelState.IsValid)  //비동기는 쉽지만 남발 할 시 피를 볼 수 있다.
            {
                studentDB.Add(student);
                await studentDB.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}