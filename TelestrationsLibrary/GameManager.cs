using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;

public class GameManager
{
    public List<Game> Games { get; } = [];

    public void CreateGame(string gameName, Player host)
    {
        var game = new Game(gameName, host);
        Games.Add(game);
    }

    public Game? GetGame(uint gameId)
    {
        return Games.FirstOrDefault(g => g.Id == gameId);
    }
}
