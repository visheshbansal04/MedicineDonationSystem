using MedicineDonation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace MedicineDonation.Controllers
{
	public class DonationController : Controller
	{
		// Simulated NGO List ( fetch this from a database)
		private List<string> GetNGOList()
		{
			return new List<string> { "NGO A", "NGO B", "NGO C", "NGO D" };
		}

		// GET: Donation/Create
		public ActionResult Create()
		{
			ViewBag.NGOList = new SelectList(GetNGOList());
			return View();
		}

		// POST: Donation/Create
		[HttpPost]
		public ActionResult Create(Donation model)
		{
			if (ModelState.IsValid)
			{
				// TODO: Save the donation details to the database
				ViewBag.Message = "Thank you for your donation!";
				return View("Success");
			}

			ViewBag.NGOList = new SelectList(GetNGOList());
			return View(model);
		}

		// GET: Donation/PastDonations (Dummy Data for Now)
		public ActionResult PastDonations()
		{
			List<Donation> donations = new List<Donation>
			{
				new Donation { MedicineName = "Paracetamol", Quantity = 10, ExpiryDate = DateTime.Now.AddMonths(6), Condition = "Unopened", DonationDate = DateTime.Now.AddDays(-5), SelectedNGO = "NGO A" },
				new Donation { MedicineName = "Cough Syrup", Quantity = 5, ExpiryDate = DateTime.Now.AddMonths(4), Condition = "Unused", DonationDate = DateTime.Now.AddDays(-10), SelectedNGO = "NGO B" }
			};

			return View(donations);
		}

		public ActionResult Success()
		{
			return View();
		}
	}
}
