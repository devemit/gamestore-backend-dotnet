using GameStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
	public DbSet<Game> Games => Set<Game>();
	public DbSet<Genre> Genres => Set<Genre>();
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Genre>().HasData(
		   new { Id = 1, Name = "Fighting" },
		   new { Id = 3, Name = "Kids" },
		   new { Id = 4, Name = "MMO" },
		   new { Id = 5, Name = "Racing" }
		);
	}
}
