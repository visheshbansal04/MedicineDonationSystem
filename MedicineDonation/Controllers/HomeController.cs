using System.Diagnostics;
using MedicineDonation.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicineDonation.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
		public ActionResult Login(string role)
		{
			if (role == "User")
				return RedirectToAction("UserLogin", "Account");
			else if (role == "NGO")
				return RedirectToAction("NGOLogin", "Account");

			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
