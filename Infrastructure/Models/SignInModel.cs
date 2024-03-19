using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignInModel
{

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email adress", Prompt = "Enter email adress", Order = 0)]
	[Required(ErrorMessage = "Email is required")]

	public string Email { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Password", Prompt = "Enter password", Order = 1)]
	[Required(ErrorMessage = "Password is required")]

	public string PassWord { get; set; } = null!;


	[Display(Name = "Remember me", Order = 2)]
	public bool RemeberMe { get; set; }
}
