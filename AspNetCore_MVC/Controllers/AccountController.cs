using AspNetCore_MVC.ViewModels;
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

		[Route("/account")]
		public IActionResult Details(AccountDetailsViewModel viewModel)
        {
			
            return View(viewModel);
        }

		[HttpPost]
		public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
		{
			return RedirectToAction(nameof(Details),viewModel);
		}
		public new IActionResult SignOut()
		{
			
			return RedirectToAction("Index","Home");
		}

	}
}
