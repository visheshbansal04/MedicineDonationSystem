using System;
using System.ComponentModel.DataAnnotations;

namespace MedicineDonation.Models
{
	public class NGO
	{
		[Required(ErrorMessage = "NGO Name is required")]
		public string NGOName { get; set; }

		[Required(ErrorMessage = "Manager Name is required")]
		public string ManagerName { get; set; }

		[Required(ErrorMessage = "Date of Establishment is required")]
		[DataType(DataType.Date)]
		public DateTime DateOfEstablishment { get; set; }

		[Required(ErrorMessage = "Contact Number is required")]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Contact Number")]
		public string ContactNumber { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "State is required")]
		public string NGOState { get; set; }

		[Required(ErrorMessage = "City is required")]
		public string NGOCity { get; set; }

		[Required(ErrorMessage = "Pincode is required")]
		[RegularExpression(@"^\d{6}$", ErrorMessage = "Invalid Pincode")]
		public string Pincode { get; set; }

		[Required(ErrorMessage = "Full Address is required")]
		public string FullAddress { get; set; }

		[Required(ErrorMessage = "NGO License Number is required")]
		public string NGOLicenseNumber { get; set; }
	}
}
