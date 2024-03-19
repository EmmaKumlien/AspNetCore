using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class UserService(UserRepository repository, AdressService adressesService)
{

	private readonly UserRepository _repository = repository;
	private readonly AdressService _adressesService = adressesService;


	public async Task<ResponsResult> CreateUserAsync(SignUpModel signUp)
	{
		try
		{
			var exists = await _repository.AlreadyExistsAsync(x => x.Email == signUp.Email);
			if(exists.StatusCode == StatusCode.EXISTS) 
			{
				return exists;
			}

			var result = await _repository.CreateAsync(UserFactory.Create(signUp));
			if (result.StatusCode != StatusCode.OK)
			{
				return result;

			}
			
			return ResponseFactory.Ok("User was created successfully");
		}
		catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
	}

	public async Task<ResponsResult> SignInUserAsync(SignInModel signIn)
	{
		try
		{
			var result = await _repository.GetOneAsync(x => x.Email == signIn.Email);
			if (result.StatusCode == StatusCode.OK && result.ContentResult!= null)
			{
				var userEntity = (UserEntity)result.ContentResult;
				if (PasswordHasher.ValidateSecurePassword(signIn.PassWord, userEntity.Password, userEntity.SecurityKey))
					return ResponseFactory.Ok();
			}


			return ResponseFactory.Error("Incorrect email or password");
		}
		catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
	}

}
