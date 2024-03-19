using Infrastructure.Models;

namespace AspNetCore_MVC.ViewModels;

public class SignUpViewModel
{
	public string PageTitle { get; set; } = "Sign Up";
	public SignUpModel SignUpForm { get; set; } = new SignUpModel();

}
