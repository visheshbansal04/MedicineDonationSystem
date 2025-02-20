using System.ComponentModel.DataAnnotations;

namespace MedicineDonation.Models
{
	public class User
	{
		
		[Required(ErrorMessage = "Full Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is required")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Phone Number is required")]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Phone Number")]
		public string PhoneNumber { get; set; }
		//public string Role { get; set; } // "Admin", "NGO", "Member"
		[Required(ErrorMessage = "State is required")]
		public string State { get; set; }

		[Required(ErrorMessage = "City is required")]
		public string City { get; set; }

		[Required(ErrorMessage = "Pincode is required")]
		[RegularExpression(@"^\d{6}$", ErrorMessage = "Invalid Pincode")]
		public string Pincode { get; set; }

		[Required(ErrorMessage = "Full Address is required")]
		public string FullAddress { get; set; }

	}
}
