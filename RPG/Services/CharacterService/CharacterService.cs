using AutoMapper;
using RPG.Models;

namespace RPG.Services.CharacterService
{
	public class CharacterService : ICharacterService
	{
		private static List<Character> characters = new List<Character> {
			new Character(),
			new Character { Id = 1, Name = "Sam" }
		};

		private readonly IMapper _mapper;

		public CharacterService(IMapper mapper)
		{
			_mapper = mapper;
		}

		public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
		{
			var serviceResponse = new ServiceResponse<List<Character>>();
			characters.Add(newCharacter);
			serviceResponse.Data = characters;
			return serviceResponse;
		}

		public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
		{
			var serviceResponse = new ServiceResponse<List<Character>>();
			serviceResponse.Data = characters;
			return serviceResponse;
		}

		public async Task<ServiceResponse<Character>> GetCharacterById(int id)
		{
			var serviceResponse = new ServiceResponse<Character>();
			var character = characters.FirstOrDefault(c => c.Id == id);
			serviceResponse.Data = character;
			return serviceResponse;
		}
	}
}
