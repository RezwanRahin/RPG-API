using Microsoft.EntityFrameworkCore;
using RPG.Models;

namespace RPG.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<Character> Characters => Set<Character>();
	}
}
