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
		public IActionResult Details()
        {
			var viewModel = new AccountDetailsViewModel();
			//viewModel.BasicInfo = _accountServices.GetBasicInfo();
			//viewModel.AdressInfo = _accountServices.GetAdressInfo();
            return View(viewModel);
        }

		[HttpPost]
		public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
		{
			//_accountServices.SaveBasicInfo(viewModel.BsicInfo);
			return RedirectToAction(nameof(Details));
		}
		[HttpPost]
		public IActionResult AdressInfo(AccountDetailsViewModel viewModel)
		{
			//_accountServices.SaveAdressInfo(viewModel.AdressInfo);
			return RedirectToAction(nameof(Details));
		}
		public new IActionResult SignOut()
		{
			
			return RedirectToAction("Index","Home");
		}


	}
}
