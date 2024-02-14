using RPG.Dtos.Character;
using RPG.Dtos.Weapon;
using RPG.Models;

namespace RPG.Services.WeaponService
{
	public interface IWeaponService
	{
		Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
	}
}
