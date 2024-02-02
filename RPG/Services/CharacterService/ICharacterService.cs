using RPG.Dtos.Character;
using RPG.Models;

namespace RPG.Services.CharacterService
{
	public interface ICharacterService
	{
		Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
		Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
		Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
	}
}
