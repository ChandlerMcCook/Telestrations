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
//byte[]? _image = null;
byte[]? _image = File.ReadAllBytes(@"C:\Users\Chandler\Downloads\example-image.png");


app.MapGet("/games", () => {
    return GameManager.Games.Select(g => new LobbyListing(g)).ToList();
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