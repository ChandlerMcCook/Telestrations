using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;

public class Game
{
    public uint Id { get; }
    public string Name { get; }
    public Player Host { get; }
    public List<Player> Players { get; } = [];
    public Game() { }
    public Game(string gameName, Player host)
    {
        Name = gameName;
        Host = host;
        Players.Add(Host);
        Id = (uint)DateTime.Now.GetHashCode(); // create game id based on hash of current time
    }
    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

}
