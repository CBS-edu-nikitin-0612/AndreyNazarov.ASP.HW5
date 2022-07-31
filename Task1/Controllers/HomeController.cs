using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
	public class HomeController : Controller
	{
		private static int _users;
		public IActionResult Index()			
		{
			_users++;
			return View( _users);
		}
	}
}
