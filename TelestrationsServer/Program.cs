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

ServerGameList gameList = new ServerGameList();
byte[]? _image = File.ReadAllBytes(@"Resources/example-image.png");


app.MapGet("/games", () => {
    return gameList.Games.Select(g => new LobbyListing(g)).ToList();
});

app.MapPost("/games", (string gameName, uint hostId) =>
{
    Player? host = gameList.GetUnmatchedPlayer(hostId);
    if (host == null)
    {
        return Results.NotFound();
    }
    uint gameId = gameList.CreateGame(gameName, host);
    return Results.Ok(gameId);
});

app.MapPost("/players", (string playerName) =>
{
    uint playerId = gameList.CreateUnmatchedPlayer(playerName);
    return Results.Ok(playerId);
});

app.MapGet("/games/{gameId}", (uint gameId) =>
{
    Game? game = gameList.GetGame(gameId);
    if (game == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(game);
});

app.MapGet("/games/{gameId}/players", (uint gameId) =>
{
    Game? game = gameList.GetGame(gameId);
    if (game == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(game.Players);
});

// mainly for testharness
app.MapGet("/games/{gameId}/players/{playerId}", (uint gameId, uint playerId) =>
{
    Game? game = gameList.GetGame(gameId);
    Player? player = game!.Players.FirstOrDefault(p => p.ID == playerId); 
    if (game == null || player == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(player.Name);
});

app.MapPost("/games/{gameId}/players/{playerId}", (uint gameId, uint playerId) =>
{
    Game? game = gameList.GetGame(gameId);
    Player? player = gameList.GetUnmatchedPlayer(playerId);
    if (game == null || player == null)
    {
        return Results.NotFound();
    }
    game.Players.Add(player);
    gameList.UnmatchedPlayers.Remove(player);
    return Results.Ok();
});

app.MapPut("/games/{gameId}/start", (uint gameId) =>
{
    Game? game = gameList.GetGame(gameId);
    if (game == null)
    {
        return Results.NotFound();
    }
    game.Start();
    return Results.Ok();
});

app.MapGet("games/{gameId}/players/{playerId}/action", (uint gameId, uint playerId) =>
{
    Game? game = gameList.GetGame(gameId);
    if (game == null || game.State == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(game.State.GetNextAction(playerId));
});

app.MapPost(
    "games/{gameId}/players/{playerId}/action",
    (uint gameId, uint playerId, ClientAction action) =>
    {
        Game? game = gameList.GetGame(gameId);
        if (game == null || game.State == null)
        {
            return Results.NotFound();
        }
        return Results.Ok(game.State.SaveAction(playerId, action));
    }
);

app.MapGet("/image", () =>
{
    if (_image == null || _image.Length == 0)
        return Results.NotFound();
    return Results.File(_image, "image/png");
});

//app.MapPost("/image", async (IFormFile file) =>
//{
//    using MemoryStream ms = new MemoryStream();
//    await file.CopyToAsync(ms);
//    _image = ms.ToArray();

//    return Results.Ok(new { size = _image.Length });
//}).Accepts<IFormFile>("multipart/form-data");

app.MapPost("/image", async (HttpRequest request) =>
{
    using var ms = new MemoryStream();
    await request.Body.CopyToAsync(ms);

    var imageBytes = ms.ToArray();
    _image = imageBytes;

    return Results.Ok(new { size = _image.Length });
});

app.Run();