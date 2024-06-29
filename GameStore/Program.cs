using GameStore;

var builder = WebApplication.CreateBuilder(args);

// connection string for sqlite
// for production we need to hide this
var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

// register the service 
await app.MigrateDbAsync();

app.Run();

