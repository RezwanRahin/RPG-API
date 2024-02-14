using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPG.Dtos.Character;
using RPG.Dtos.Weapon;
using RPG.Models;
using RPG.Services.WeaponService;

namespace RPG.Controllers
{
	[Route("api/[controller]")]
	[Authorize]
	[ApiController]
	public class WeaponController : ControllerBase
	{
		private readonly IWeaponService _weaponService;

		public WeaponController(IWeaponService weaponService)
		{
			_weaponService = weaponService;
		}

		[HttpPost]
		public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
		{
			return Ok(await _weaponService.AddWeapon(newWeapon));
		}
	}
}
