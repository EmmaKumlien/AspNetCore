
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.Models;

public class AccountBasicInfoModel
{
	[DataType(DataType.ImageUrl)]
	public string? ProfilePicture { get; set; }

	[Display(Name = "First Name", Prompt = "Enter first name", Order = 0)]
	[Required(ErrorMessage = "First name is required")]
	public string FirstName { get; set; } = null!;

	[Display(Name = "Last Name", Prompt = "Enter last name", Order = 1)]
	[Required(ErrorMessage = "Last name is required")]
	public string LastName { get; set; } = null!;

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email adress", Prompt = "Enter email adress", Order = 2)]
	[Required(ErrorMessage = "Email is required")]
	[RegularExpression("^([a-zA-Z0-9]+[a-zA-Z0-9._%-]*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,4})$", ErrorMessage = "Your email adress is invalid")]
	public string Email { get; set; } = null!;

	[DataType(DataType.PhoneNumber)]
	[Display(Name = "Phone number", Prompt = "Enter your phone number", Order = 3)]
	[Required(ErrorMessage = "Password is required")]
	[RegularExpression("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number is invalid")]
	public string? Phone { get; set; }

	[DataType(DataType.MultilineText)]
	[Display(Name = " Bio", Prompt = "Write something about yourself...", Order = 4)]
	public string? Bio { get; set; }

}
