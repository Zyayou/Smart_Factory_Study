using Microsoft.AspNetCore.Mvc;
using MVC_ScoreQuiz.Models;
using System.Diagnostics;
using System.Reflection;

namespace MVC_ScoreQuiz.Controllers
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
        [HttpPost]
        public string Index(Subject subject)
        {
            double score100 = (subject.kor + subject.eng + subject.math + subject.soc + subject.sci) / 5;
            double score4 = (Cul(subject.kor) + Cul(subject.eng) + Cul(subject.math) + Cul(subject.soc) + Cul(subject.sci)) / 5;
            
            return "4.5점 기준 : 평점 " + score4 + "\r\n100점 기준 : 평점 " + score100;

        }
        public double Cul(int sco)
        {
            if (sco == 100) { return 4.5; }
            else if (sco == 95){ return 4.0; }
            else if (sco == 90) { return 3.5; }
            else if (sco == 80) { return 3.0; }
            else if (sco == 75) { return 2.5; }
            else if (sco == 70) { return 2.0; }
            else if (sco == 65) { return 1.5; }
            else if (sco == 60) { return 1.0; }
            else { return 0; }
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