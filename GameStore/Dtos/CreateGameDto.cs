using System.ComponentModel.DataAnnotations;

namespace GameStore;
// data annotation for validation
// endpoint filter for minimal apis for better validation
// we useed minimalapis.extensions nugget package
public record class CreateGameDto(
	[Required][StringLength(50)] string Name,
	int GenreId,
	[Range(1, 100)] decimal Price,
	DateOnly ReleaseDate
	);



