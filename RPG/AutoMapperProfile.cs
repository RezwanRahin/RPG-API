using AutoMapper;
using RPG.Dtos.Character;
using RPG.Models;

namespace RPG
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Character, GetCharacterDto>();
			CreateMap<AddCharacterDto, Character>();
		}
	}
}
