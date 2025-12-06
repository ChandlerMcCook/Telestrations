using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;

public class ServerGameList
{
    public List<Game> Games { get; } = [];
    public List<Player> UnmatchedPlayers { get; } = [];

    public uint CreateGame(string gameName, Player host)
    {
        var game = new Game(gameName, host);
        Games.Add(game);
        return game.ID;
    }

    public uint CreateUnmatchedPlayer(string playerName)
    {
        var player = new Player(playerName);
        UnmatchedPlayers.Add(player);
        return player.ID;
    }

    public Game? GetGame(uint gameId)
    {
        return Games.FirstOrDefault(g => g.ID == gameId);
    }

    public Player? GetUnmatchedPlayer(uint playerId)
    {
        return UnmatchedPlayers.FirstOrDefault(p =>  p.ID == playerId);
    }

    public void RemoveGame(uint gameId)
    {

    }

    public void StartGame(uint gameId)
    {

    }
}
