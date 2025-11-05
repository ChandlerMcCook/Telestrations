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
    public static async Task<List<Game>?> GetGamesAsync()
    {
        HttpResponseMessage response = await ServerCall.MakeGetRequestAsync("/games");

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            return null;
        }

        string gamesJson = await response.Content.ReadAsStringAsync();
        List<Game>? games = JsonSerializer.Deserialize<List<Game>?>(gamesJson);
        return games;
    }

    public static async Task<bool> CreateGameAsync(string gameName, Player host)
    {
        var payload = new
        {
            gameName,
            host
        };

        HttpResponseMessage response = await ServerCall.MakePostRequestAsync("/games", payload);

        return response.IsSuccessStatusCode;
    }
}
