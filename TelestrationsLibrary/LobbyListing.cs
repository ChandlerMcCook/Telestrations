using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;

public class LobbyListing
{
    public uint Id { get; set; }
    public string GameName { get; set; }
    public string HostName { get; set; }
    public string PlayerCount { get; set; }
    public LobbyListing() { }
    public LobbyListing(Game game)
    {
        Id = game.Id;
        GameName = game.Name;
        HostName = game.Host.Name;
        PlayerCount = $"{game.Players.Count} / {Globals.MAX_PLAYERS_PER_GAME}";
    }
}
