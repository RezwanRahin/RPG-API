using Microsoft.AspNetCore.Mvc;
using RPG.Models;

namespace RPG.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CharacterController : ControllerBase
	{
		private static List<Character> characters = new List<Character> {
			new Character(),
			new Character { Name = "Sam" }
		};
	}
}
