using MedicineDonation.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicineDonation.Controllers
{
	public class NGOController : Controller
	{
		//private static List<Medicine> medicines = new List<Medicine>();
		//private static List<Medicine> medicines = new List<Medicine>
		//{
		//	new Medicine { Id = 1, Name = "Paracetamol", ExpiryDate = new DateTime(2025, 05, 20), DonorName = "John Doe", Status = "Pending" },
		//	new Medicine { Id = 2, Name = "Amoxicillin", ExpiryDate = new DateTime(2024, 11, 15), DonorName = "Jane Smith", Status = "Approved" },
		//	new Medicine { Id = 3, Name = "Cough Syrup", ExpiryDate = new DateTime(2026, 02, 10), DonorName = "Alice Johnson", Status = "Rejected" },
		//	new Medicine { Id = 4, Name = "Ibuprofen", ExpiryDate = new DateTime(2025, 09, 05), DonorName = "Mark Wilson", Status = "Pending" },
		//	new Medicine { Id = 5, Name = "Vitamin C", ExpiryDate = new DateTime(2026, 07, 30), DonorName = "Emma Brown", Status = "Approved" }
		//};
		public IActionResult Index()
		{
			return View();
		}

		//public IActionResult ViewMedicines()
		//{
		//	var approvedMedicines = medicines.Where(m => m.Status == "Approved").ToList();
		//	return View("ViewMedicines",approvedMedicines);
		//}
		public ActionResult NGOLogin()
		{
			return View();
		}
		// GET: NGO/Register
		public ActionResult NGORegister()
		{
			return View();
		}

		// POST: NGO/Register
		[HttpPost]
		public ActionResult NGORegister(NGO model)
		{
			if (ModelState.IsValid)
			{
				// TODO: Save NGO details to the database
				ViewBag.Message = "NGO Registration Successful!";
				return RedirectToAction("Login"); // Redirect to login page after registration
			}
			return View(model);
		}
		public ActionResult NGODashboard()
		{
			return View();
		}
	}
}
