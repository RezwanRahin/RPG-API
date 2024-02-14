using AutoMapper;
using RPG.Data;
using RPG.Dtos.Character;
using RPG.Dtos.Weapon;
using RPG.Models;

namespace RPG.Services.WeaponService
{
	public class WeaponService : IWeaponService
	{
		private readonly DataContext _context;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IMapper _mapper;

		public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
		{
			_context = context;
			_httpContextAccessor = httpContextAccessor;
			_mapper = mapper;
		}

		public Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
		{
			throw new NotImplementedException();
		}
	}
}
