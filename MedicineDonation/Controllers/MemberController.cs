using MedicineDonation.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicineDonation.Controllers
{
	public class MemberController : Controller
	{
		private static List<User> users = new List<User>();

		public IActionResult Index()
		{
			return View();
		}

		public ActionResult UserLogin()
		{
			return View();
		}

		public ActionResult UserRegister()
		{
			return View();
		}

		// POST: User/Register
		[HttpPost]
		public ActionResult UserRegister(User model)
		{
			if (ModelState.IsValid)
			{
				// TODO: Save user to the database
				ViewBag.Message = "Registration successful!";
				return RedirectToAction("Login"); // Redirect to login page after registration
			}
			return View(model);
		}
		public ActionResult UserDashboard()
		{
			User user = new User() 
			{
				Name = "John Doe",
				Email = "johndoe@example.com",
				Password = "Secure@123",
				ConfirmPassword = "Secure@123",
				PhoneNumber = "9876543210",
				State = "Maharashtra",
				City = "Mumbai",
				Pincode = "400001",
				FullAddress = "123, ABC Street, Mumbai, Maharashtra, India"
			};
			return View(user);
		}
	}
}
