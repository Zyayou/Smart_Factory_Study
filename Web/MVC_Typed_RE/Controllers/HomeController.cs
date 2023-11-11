using Microsoft.AspNetCore.Mvc;
using MVC_Typed_RE.Models;
using System.Diagnostics;

namespace MVC_Typed_RE.Controllers
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
			var myEmployees = new List<People>()
			{
				new People() { ID = 101, Name = "홍길동", Position = "대리", Salary = 35000},
				new People() { ID = 102, Name = "이순신", Position = "부장", Salary = 60000},
				new People() { ID = 103, Name = "강감찬", Position = "상무", Salary = 70000}

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