using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class AdressService(AdressRepository repository)
{
	private readonly AdressRepository _repository = repository;

	public async Task<ResponsResult> GetOrCreateAdressAsync(string streetName, string postal, string city)
	{
		try
		{
			var result = await GetAdressAsync(streetName, postal, city);
			if(result.StatusCode == StatusCode.NOT_FOUND)
			{
				result = await CreateAdressAsync(streetName, postal, city);
			}
			return result;
		}
		catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
	}

	public async Task<ResponsResult> CreateAdressAsync(string streetName, string postal, string city)
	{
		try
		{
			var exists = await _repository.AlreadyExistsAsync(x => x.StreetName == streetName && x.PostalCode == postal && x.City == city);
			if (exists == null)
			{
				var result = await _repository.CreateAsync(AdressFactory.Create(streetName, postal, city));

				if(result.StatusCode == StatusCode.OK)
				{
					return ResponseFactory.Ok(AdressFactory.Create((AdressEntity)result.ContentResult!));
					
				}
				return result;


			}
			return exists;
		}
		catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
	}

	public async Task<ResponsResult> GetAdressAsync(string streetName, string postal, string city)
	{
		try
		{
			var result = await _repository.GetOneAsync(x => x.StreetName == streetName && x.PostalCode == postal && x.City == city);
			return result;
		}
		catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
	}
}
