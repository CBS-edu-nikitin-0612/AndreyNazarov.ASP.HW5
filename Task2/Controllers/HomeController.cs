using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Task2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string value, DateTime date)
		{
			CookieOptions options = new CookieOptions();
			options.Expires = date;
			Response.Cookies.Append("test", value, options);

			return View();
		}

		public IActionResult Test()
		{
			if (Request.Cookies["test"] != null)
			{
				ViewBag.CookieExist = true;
				ViewBag.Value = Request.Cookies["test"];
			}
			else
			{
				ViewBag.CookieExist = false;
			}
			return View();
		}
	}
}