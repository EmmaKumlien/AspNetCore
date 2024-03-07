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
		return RedirectToAction("signIn","Auth");
	}
}
