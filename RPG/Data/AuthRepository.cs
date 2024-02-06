using RPG.Models;

namespace RPG.Data
{
	public class AuthRepository : IAuthRepository
	{
		private readonly DataContext _context;

		public AuthRepository(DataContext context)
		{
			_context = context;
		}

		public Task<ServiceResponse<string>> Login(string username, string password)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<int>> Register(User user, string password)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UserExists(string username)
		{
			throw new NotImplementedException();
		}
	}
}
