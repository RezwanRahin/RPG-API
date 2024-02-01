using RPG.Models;

namespace RPG.Services.CharacterService
{
	public class CharacterService : ICharacterService
	{
		private static List<Character> characters = new List<Character> {
			new Character(),
			new Character { Id = 1, Name = "Sam" }
		};

		public List<Character> AddCharacter(Character newCharacter)
		{
			characters.Add(newCharacter);
			return characters;
		}

		public List<Character> GetAllCharacters()
		{
			throw new NotImplementedException();
		}

		public Character GetCharacterById(int id)
		{
			throw new NotImplementedException();
		}
	}
}