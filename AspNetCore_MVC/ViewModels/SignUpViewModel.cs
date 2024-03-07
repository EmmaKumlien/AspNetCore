using AspNetCore_MVC.Models;

namespace AspNetCore_MVC.ViewModels;

public class SignUpViewModel
{
	public string PageTitle { get; set; } = "Sign Up";
	public SignUpFormModel SignUpForm { get; set; } = new SignUpFormModel();

}
