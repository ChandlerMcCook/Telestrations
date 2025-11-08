using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TelestrationsLibrary;

namespace TelestrationsUI;
internal class FrontendLogic
{
    public static async Task<List<LobbyListing>?> GetGamesAsync()
    {
        HttpResponseMessage response = await ServerCall.MakeGetRequestAsync("/games");

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            return null;
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        string lobbyJson = await response.Content.ReadAsStringAsync();
        List<LobbyListing>? lobbyListings = JsonSerializer.Deserialize<List<LobbyListing>?>(lobbyJson, options);
        return lobbyListings;
    }

    public static async Task<bool> CreateGameAsync(string gameName, Player host)
    {
        HttpResponseMessage response = await ServerCall.MakePostRequestAsync($"/games?gameName={gameName}", host);

        return response.IsSuccessStatusCode;
    }
}
