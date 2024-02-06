using Microsoft.AspNetCore.Mvc;
using RPG.Data;
using RPG.Dtos.User;
using RPG.Models;

namespace RPG.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthRepository _authRepo;

		public AuthController(IAuthRepository authRepo)
		{
			_authRepo = authRepo;
		}

		[HttpPost("Register")]
		public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
		{
			var response = await _authRepo.Register(
				new User { Username = request.Username }, request.Password
			);

			if (!response.Success)
			{
				return BadRequest(response);
			}
			return Ok(response);
		}
	}
}
