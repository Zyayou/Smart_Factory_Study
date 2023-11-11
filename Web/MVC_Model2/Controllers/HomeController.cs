using Microsoft.AspNetCore.Mvc;
using MVC_Model2.Models;
using MVC_Model2.Repository;
using System.Diagnostics;

namespace MVC_Model2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentModel> getAllStudent()
        {
            return _studentRepository.getAllStudents();
        }
        public StudentModel GetStudent(int id)
        {
            return _studentRepository.getStudentById(id);
        }
        public IActionResult Index()
        {
            /*
            var st = new StudentModel()
            {
                ID = 1,
                Name = "홍길동",
                HP = "010-1111-1111",
                Majer = "컴퓨터공학과"
            };

            ViewData["data1"]=st;
            */

            /*
            var students = new List<StudentModel> {
            
                new StudentModel {ID = 1, Name = "홍길동", HP = "010-1111-1111", Majer = "컴퓨터공학과"},
                new StudentModel {ID = 2, Name = "이순신", HP = "010-2222-2222", Majer = "정보통신공학과"},
                new StudentModel {ID = 3, Name = "강감찬", HP = "010-3333-3333", Majer = "기계설계공학과"}
            };

            ViewData["data1"] = students;
            */



            return View();
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