using Microsoft.EntityFrameworkCore;

namespace GameStore;

public static class DataExtensions
{
	// this class is used to automatically update the database
	public static async Task MigrateDbAsync(this WebApplication app)
	{
		using var scope = app.Services.CreateScope();
		var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
		await dbContext.Database.MigrateAsync();
	}

}
