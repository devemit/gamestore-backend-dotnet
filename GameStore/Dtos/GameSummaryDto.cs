namespace GameStore;

// we use record beacuse records are immutable
public record class GameSummaryDto(int Id, string Name, string Genre, decimal Price, DateOnly ReleaseDate);

