using GameStore.Entities;

namespace GameStore;
// mapping Object mapping is a critical technique in software development that involves converting data from one object type into another. Essentially, it's about matching the properties of two different types of objects, so that their data can be seamlessly passed from one to another. This is particularly useful when you need to transfer data between objects that are not compatible or were designed to work with different architectures or data models.
public static class GameMapping
{
	public static Game ToEntity(this CreateGameDto game)
	{
		return new Game()
		{
			Name = game.Name,
			GenreId = game.GenreId,
			Price = game.Price,
			ReleaseDate = game.ReleaseDate
		};
	}
	public static Game ToEntity(this UpdateGameDto game, int id)
	{
		return new Game()
		{
			Id = id,
			Name = game.Name,
			GenreId = game.GenreId,
			Price = game.Price,
			ReleaseDate = game.ReleaseDate
		};
	}

	public static GameSummaryDto ToGameSummaryDto(this Game game)
	{
		return new(
				  game.Id,
				  game.Name,
				  game.Genre!.Name,
				  game.Price,
				  game.ReleaseDate
			  );
	}

	public static GameDetailsDto ToGameDetailsDto(this Game game)
	{
		return new(
				  game.Id,
				  game.Name,
				  game.GenreId,
				  game.Price,
				  game.ReleaseDate
			  );
	}

}
