using AspNetCore_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
	[HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
		return View(viewModel);
    }

	[Route("/signup")]
	[HttpPost]
	public IActionResult SignUp(SignUpViewModel model)
	{
		if(!ModelState.IsValid)
		{
			return View(model);
		}
		return RedirectToAction("Details","Account");
	}

	[Route("/signin")]
	[HttpGet]
	public IActionResult SignIn()
	{
		var viewModel = new SignInViewModel();
		return View(viewModel);
	}


	[Route("/signin")]
	[HttpPost]
	public IActionResult Signin(SignInViewModel model)
	{
		if (!ModelState.IsValid)
		{
			
			return View(model);
		}

		//var result = _authService.SignIn(model.SignIn)
		//if(result)
		//return RedirectToAction("Account", "Index");

		model.ErrorMessage = "Incorrect password or email adress";
		return View(model);
	}
}
