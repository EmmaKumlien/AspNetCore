using Infrastructure.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignUpModel
{
	[DataType(DataType.Text)]
	[Display(Name = "First Name", Prompt = "Enter first name", Order = 0)]
	[Required(ErrorMessage = "First name is required")]
	[MinLength(2, ErrorMessage = "First name is required")]
	public string FirstName { get; set; } = null!;

	[DataType(DataType.Text)]
	[Display(Name = "Last Name", Prompt = "Enter last name", Order = 1)]
	[Required(ErrorMessage = "Last name is required")]
	[MinLength(2, ErrorMessage = "Last name is required")]
	public string LastName { get; set; } = null!;

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email adress", Prompt = "Enter email adress", Order = 2)]
	[Required(ErrorMessage = "Email is required")]
	[RegularExpression("^(([^<>()\\[\\]\\\\.,;:\\s@\"]+(\\.[^<>()\\[\\]\\\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$", ErrorMessage ="Your email adress is invalid")]
	public string Email { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Password", Prompt = "Enter password", Order = 3)]
	[Required(ErrorMessage = "Password is required")]
	[RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Your password is invalid")]
	public string PassWord { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Confirm password", Prompt = "Confirm password", Order = 4)]
	[Required(ErrorMessage = "Password must be confirmed")]
	[Compare(nameof(PassWord), ErrorMessage = "Password does not match")]
	public string Confirm { get; set; } = null!;

	[Display(Name = "I agree to the Terms and Conditions.", Order = 5)]
	[CheckBoxRequired(ErrorMessage = "You must agree to the terms and conditions")]
	public bool Terms { get; set; } = false;

}
