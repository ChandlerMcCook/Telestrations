using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IGamePlayersData
    {
        Task DeleteGamePlayer(int gameId, int playerId);
        Task DeleteGamePlayersByGame(int gameId);
        Task<IEnumerable<GamePlayersModel>> GetGamePlayers(int gameId);
        Task InsertGamePlayer(GamePlayersModel gamePlayer);
    }
}