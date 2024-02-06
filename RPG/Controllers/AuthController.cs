using Microsoft.AspNetCore.Mvc;
using RPG.Data;

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
	}
}
