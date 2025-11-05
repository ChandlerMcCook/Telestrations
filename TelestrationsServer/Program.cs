using TelestrationsLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var GameManager = new GameManager();

app.MapGet("/games", () => {
    return GameManager.Games;
});

app.MapPost("/games", (string gameName, Player host) =>
{
    GameManager.CreateGame(gameName, host);
    return Results.Ok();
});

app.MapGet("/games/{gameId}", (uint gameId) =>
{
    Game? game = GameManager.GetGame(gameId);
    if (game == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(game);
});

app.MapPost("/games/{gameId}/players", (uint gameId, Player player) =>
{
    Game? game = GameManager.GetGame(gameId);
    if (game == null)
    {
        return Results.NotFound();
    }
    game.AddPlayer(player);
    return Results.Ok();
});

app.Run();