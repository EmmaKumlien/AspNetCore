using AspNetCore_MVC.Models;

namespace AspNetCore_MVC.ViewModels;

public class AccountDetailsViewModel
{
	public string PageTitle { get; set; } = "Account Details";
	public AccountBasicInfoModel BasicInfo { get; set; } = new AccountBasicInfoModel()
	{
		ProfilePicture = "images/Account/kattbild.svg",
		FirstName="Kattis",
		LastName="Kattsson",
		Email="Katt@Kurr.ar",
		Phone="031-123456"
	};
	public AccountAdressInfoModel AdressInfo { get; set; }= new AccountAdressInfoModel ()
	{
		AdressLine_1="Kattgatan 1",
		PostalCode="111 22",
		City="Kattstad"
	};
}
