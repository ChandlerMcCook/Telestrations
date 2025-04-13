using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;

public class GameData : IGameData
{
    private readonly ISqlDataAccess _db;

    public GameData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<GameModel>> GetGames() =>
        // since you have to pass something for type U, pass an empty object
        _db.LoadData<GameModel, dynamic>("dbo.spGame_GetAll", new { });

    // potentially nullable
    public async Task<GameModel?> GetGame(int id)
    {
        var results = await _db.LoadData<GameModel, dynamic>(
            storedProcedure: "dbo.spGame_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertGame(GameModel Game) =>
        _db.SaveData("dbo.spGame_Insert", new { Game.Name, Game.HostId });
    public Task UpdateGame(GameModel Game) =>
        _db.SaveData("dbo.spGame_Update", new { Game.Id, Game.Started });

    public Task DeleteGame(int id) =>
        _db.SaveData("dbo.spGame_Delete", new { Id = id });
}
