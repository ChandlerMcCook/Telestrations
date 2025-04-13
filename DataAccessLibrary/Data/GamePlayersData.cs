

using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public class GamePlayersData : IGamePlayersData
    {
        private readonly ISqlDataAccess _db;

        public GamePlayersData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<GamePlayersModel>> GetGamePlayers(int gameId) =>
            _db.LoadData<GamePlayersModel, dynamic>("dbo.spGamePlayers_GetPlayersByGame", new { GameId = gameId });

        public Task InsertGamePlayer(GamePlayersModel gamePlayer) =>
            _db.SaveData("dbo.spGamePlayers_Insert", new { gamePlayer.GameId, gamePlayer.PlayerId });

        public Task DeleteGamePlayer(int gameId, int playerId) =>
            _db.SaveData("dbo.spGamePlayers_Delete", new { GameId = gameId, PlayerId = playerId });

        public Task DeleteGamePlayersByGame(int gameId) =>
            _db.SaveData("dbo.spGamePlayers_DeleteByGame", new { GameId = gameId });
    }
}
