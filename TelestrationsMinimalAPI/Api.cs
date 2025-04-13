namespace TelestrationsMinimalAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app) // use this to extend a method onto app
    {
        // User routes
        app.MapGet("/users", GetUsers);
        app.MapGet("/users/{id}", GetUser);
        app.MapPost("/users", InsertUser);
        app.MapPut("/users", UpdateUser);
        app.MapDelete("/users", DeleteUser);

        // Game routes
        app.MapGet("/games", GetGames);
        app.MapGet("/games/{id}", GetGame);
        app.MapPost("/games", InsertGame);
        app.MapPut("/games", UpdateGame);
        app.MapDelete("/games", DeleteGame);

        // GamePlayers routes
        app.MapGet("/games/{gameId}/players", GetGamePlayers);
        app.MapPost("/games/players", InsertGamePlayer);
        app.MapDelete("/games/{gameId}/players/{playerId}", DeleteGamePlayer);
        app.MapDelete("/games/{gameId}/players", DeleteGamePlayersByGame);
    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {
            var result = await data.GetUser(id);
            return result is null ? Results.NotFound() : Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertUser(UserModel user, IUserData data)
    {
        try
        {
            await data.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
    {
        try
        {
            await data.UpdateUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        try
        {
            await data.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetGames(IGameData data)
    {
        try
        {
            return Results.Ok(await data.GetGames());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetGame(int id, IGameData data)
    {
        try
        {
            var result = await data.GetGame(id);
            return result is null ? Results.NotFound() : Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertGame(GameModel game, IGameData data)
    {
        try
        {
            await data.InsertGame(game);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateGame(GameModel game, IGameData data)
    {
        try
        {
            await data.UpdateGame(game);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteGame(int id, IGameData data)
    {
        try
        {
            await data.DeleteGame(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetGamePlayers(int gameId, IGamePlayersData data)
    {
        try
        {
            var result = await data.GetGamePlayers(gameId);
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertGamePlayer(GamePlayersModel gamePlayer, IGamePlayersData data)
    {
        try
        {
            await data.InsertGamePlayer(gamePlayer);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteGamePlayer(int gameId, int playerId, IGamePlayersData data)
    {
        try
        {
            await data.DeleteGamePlayer(gameId, playerId);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteGamePlayersByGame(int gameId, IGamePlayersData data)
    {
        try
        {
            await data.DeleteGamePlayersByGame(gameId);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
