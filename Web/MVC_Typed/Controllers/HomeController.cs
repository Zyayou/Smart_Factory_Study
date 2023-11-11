using Microsoft.AspNetCore.Mvc;
using MVC_Typed.Models;
using System.Diagnostics;

namespace MVC_Typed.Controllers
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
            /*
            Employee obj = new Employee
            {
                EmpNo = 100,
                EmpName = "홍길동",
                Designation = "대리",
                Salary = 25000

            };
            */

            //1. ViewData["data1"] = obj;
            //2. ViewBag.Employee = obj;
            //3. TempData["data1"] = obj;
            
            //4.Strongly Type
            //return View(obj);


            var myEmployees = new List<Employee>
            {
                new Employee {EmpNo = 100, EmpName = "홍길동", Designation = "대리", Salary = 30000},
                new Employee {EmpNo = 200, EmpName = "이순신", Designation = "부장", Salary = 80000},
                new Employee {EmpNo = 300, EmpName = "강감찬", Designation = "상무", Salary = 70000}
            };


            return View(myEmployees);
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