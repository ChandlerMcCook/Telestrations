using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IGameData
    {
        Task DeleteGame(int id);
        Task<GameModel?> GetGame(int id);
        Task<IEnumerable<GameModel>> GetGames();
        Task InsertGame(GameModel Game);
        Task UpdateGame(GameModel Game);
    }
}