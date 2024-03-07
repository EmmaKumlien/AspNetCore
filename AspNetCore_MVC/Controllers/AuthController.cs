using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    public IActionResult SignUp()
    {
		ViewData["Title"] = "Sign Up";
		return View();
    }
}
