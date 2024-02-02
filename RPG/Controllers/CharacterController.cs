using Microsoft.AspNetCore.Mvc;
using RPG.Models;
using RPG.Services.CharacterService;

namespace RPG.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CharacterController : ControllerBase
	{
		private readonly ICharacterService _characterService;

		public CharacterController(ICharacterService characterService)
		{
			_characterService = characterService;
		}

		[HttpGet("GetAll")]
		public ActionResult<List<Character>> Get()
		{
			return Ok(characters);
		}

		[HttpGet("{id}")]
		public ActionResult<Character> GetSingle(int id)
		{
			return Ok(characters.FirstOrDefault(c => c.Id == id));
		}

		[HttpPost]
		public ActionResult<List<Character>> AddCharacter(Character newCharacter)
		{
			characters.Add(newCharacter);
			return Ok(characters);
		}
	}
}
