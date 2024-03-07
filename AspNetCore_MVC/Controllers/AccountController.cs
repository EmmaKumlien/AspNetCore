using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class AccountController : Controller
    {
		//private readonly AccountService _accountService;

		//public AccountController(AccountService accountService)
		//{
		//	_accountService = accountService;
		//}
		public IActionResult Index()
        {
            ViewData["Title"] = "Account Details";
            return View();
        }
		
		public new IActionResult SignOut()
		{
			
			return RedirectToAction("Index","Home");
		}

	}
}
