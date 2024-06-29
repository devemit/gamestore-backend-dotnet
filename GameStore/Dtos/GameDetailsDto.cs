namespace GameStore;

// we use record beacuse records are immutable
public record class GameDetailsDto(int Id, string Name, int GenreId, decimal Price, DateOnly ReleaseDate);

