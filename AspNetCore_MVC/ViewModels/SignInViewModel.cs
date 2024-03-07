using AspNetCore_MVC.Models;

namespace AspNetCore_MVC.ViewModels;

public class SignInViewModel
{
	public string PageTitle { get; set; } = "Sign In";
	public SignInModel SignIn { get; set; } = new SignInModel();
}
