using Microsoft.EntityFrameworkCore;

namespace Wine.Models
{
	public class WineContext : DbContext
	{
		public DbSet <Varietal> Varietals { get; set; }

		public WineContext(DbContextOptions options) : base(options) { }
	}
}