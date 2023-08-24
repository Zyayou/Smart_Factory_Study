using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_Quiz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int number1, int number2)
        {
                ViewBag.Result1 = number1 + number2;
            
                ViewBag.Result2 = number1 - number2;
            
                ViewBag.Result3 = number1 * number2;
           
                ViewBag.Result4 = number1 / number2;
            
            return View();
        }

        public IActionResult DateDays() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult DateDays(DateTime day1, DateTime day2)
        {
            TimeSpan result =  day2 - day1;
            ViewBag.Result = result.Days;
            return View();
        }

        public IActionResult PIBW()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PIBW(double Height, double Weight, string Gender)
        {
            double resultP =0;
            string result="";
            if(Gender == "남성")
            {
                resultP = (Weight / (Height/100 * Height/100 * 22)) * 100;
            }
            else if(Gender == "여성")
            {
                resultP = (Weight / ((Height/100) * (Height/100) * 21)) * 100;
            }

            if (resultP < 90) { result = "저체중"; }
            else if (90 <= resultP && resultP < 110) { result = "정상 체중"; }
            else if (110 <= resultP && resultP < 120) { result = "과체중"; }
            else if (120 <= resultP && resultP < 130) { result = "경도 비만"; }
            else if (130 <= resultP && resultP < 160) { result = "중정도 비만"; }
            else if (160 <= resultP) { result = "고도 비만"; }

            ViewBag.Result = result;
            return View();
        }
    }
}
