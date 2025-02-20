using System;
using System.ComponentModel.DataAnnotations;

namespace MedicineDonation.Models
{
	public class Donation
	{
		[Required(ErrorMessage = "Medicine Name is required")]
		public string MedicineName { get; set; }

		[Required(ErrorMessage = "Quantity is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
		public int Quantity { get; set; }

		[Required(ErrorMessage = "Expiry Date is required")]
		[DataType(DataType.Date)]
		public DateTime ExpiryDate { get; set; }

		[Required(ErrorMessage = "Condition is required")]
		public string Condition { get; set; }

		[Required(ErrorMessage = "Donation Date is required")]
		[DataType(DataType.Date)]
		public DateTime DonationDate { get; set; }

		[Required(ErrorMessage = "Please select an NGO")]
		public string SelectedNGO { get; set; }
	}
}
