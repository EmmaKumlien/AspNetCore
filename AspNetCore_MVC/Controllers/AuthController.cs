using AspNetCore_MVC.ViewModels;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class AuthController(UserService userService) : Controller
{
	private readonly UserService _userService = userService;

	[Route("/signup")]
	[HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
		return View(viewModel);
    }

	[Route("/signup")]
	[HttpPost]
	public async Task<IActionResult> SignUp(SignUpViewModel model)
	{
		if(ModelState.IsValid)
		{
			var result = await _userService.CreateUserAsync(model.SignUpForm);
			if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
			{
				return RedirectToAction("signIn", "Auth");
			}
		}
		
		return View(model);

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
	public async Task<IActionResult> Signin(SignInViewModel model)
	{
		if (ModelState.IsValid)
		{
			var result = await _userService.SignInUserAsync(model.SignIn);
			if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
				return RedirectToAction("Details", "Account");
			
		}

	
		

		model.ErrorMessage = "Incorrect password or email adress";
		return View(model);
	}
}
