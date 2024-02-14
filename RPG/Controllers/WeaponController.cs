using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers
{
	[Route("api/[controller]")]
	[Authorize]
	[ApiController]
	public class WeaponController : ControllerBase
	{
	}
}
