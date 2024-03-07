using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.Models;

public class AccountAdressInfoModel
{
	[Display(Name = "Adress 1", Prompt = "Enter adress", Order = 0)]
	[Required(ErrorMessage = "Adress line is required")]
	
	public string AdressLine_1 { get; set; } = null!;

	[Display(Name = "Adress 2", Prompt = "Enter second adress", Order = 1)]
	public string? AdressLine_2 { get; set; }

	[Display(Name = "Postal code", Prompt = "Write your postal code", Order = 2)]
	[Required(ErrorMessage = "Postal code is required")]
	[DataType(DataType.PostalCode)]
	public string PostalCode { get; set; } = null!;

	[Display(Name = "City", Prompt = "Enter name of city", Order = 3)]
	[Required(ErrorMessage = "City is required")]
	public string City { get; set; } = null!;
}
