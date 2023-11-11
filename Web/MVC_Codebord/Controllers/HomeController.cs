using Microsoft.AspNetCore.Mvc;
using MVC_Codebord.Models;
using System.Diagnostics;

namespace MVC_Codebord.Controllers
{
	public class HomeController : Controller
	{
		private readonly CodeBoardDBContext DiaryDB;

		public HomeController(CodeBoardDBContext DiaryDB)
		{
			this.DiaryDB = DiaryDB;
		}
		public IActionResult Index()
		{
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