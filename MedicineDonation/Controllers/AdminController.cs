//using MedicineDonation.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace MedicineDonation.Controllers
//{
//	public class AdminController : Controller
//	{
//		private static List<User> users = new List<User>();
//		private static List<Medicine> medicines = new List<Medicine>();

//		public IActionResult Index()
//		{
//			return View();
//		}

//		public IActionResult ManageUsers()
//		{
//			return View(users);
//		}

//		public IActionResult ApproveMedicine(int id)
//		{
//			var med = medicines.FirstOrDefault(m => m.Id == id);
//			if (med != null) med.Status = "Approved";
//			return RedirectToAction("Index");
//		}

//		public IActionResult RejectMedicine(int id)
//		{
//			var med = medicines.FirstOrDefault(m => m.Id == id);
//			if (med != null) med.Status = "Rejected";
//			return RedirectToAction("Index");
//		}
//	}
//}
