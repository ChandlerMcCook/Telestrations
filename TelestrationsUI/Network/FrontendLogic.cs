using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TelestrationsLibrary;

namespace TelestrationsUI.Network;
internal class FrontendLogic
{
    public static async Task<List<LobbyListing>?> GetGames()
    {
        HttpResponseMessage response = await ServerCall.Get("/games");

        if (response.IsSuccessStatusCode == false)
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

    public static async Task<uint> CreateGame(string gameName, Player host)
    {
        HttpResponseMessage response = await ServerCall.PostJson($"/games?gameName={gameName}", host);
        return await response.Content.ReadFromJsonAsync<uint>();
    }

    public static async Task<List<Player>?> GetPlayers(uint gameId)
    {
        HttpResponseMessage response = await ServerCall.Get($"games/{gameId}/players");

        if (response.IsSuccessStatusCode == false)
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            return null;
        }

        string playerJson = await response.Content.ReadAsStringAsync();
        List<Player>? players = JsonSerializer.Deserialize<List<Player>?>(playerJson);
        return players;
    }

    public static async Task<bool> SendDrawing(Bitmap image)
    {
        HttpResponseMessage response = await ServerCall.PostImage("/image", image);
        return response.IsSuccessStatusCode;
    }

    public static async Task<Bitmap> GetDrawing()
    {
        HttpResponseMessage response = await ServerCall.Get("/image");

        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();
        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            return new Bitmap(ms);
        }
    }

    public static Bitmap ConvertByteArrToBitmap(byte[] bytes)
    {
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            return new Bitmap(ms);
        }
    }

    public static async Task<bool> StartGame(uint gameId)
    {
        HttpResponseMessage response = await ServerCall.Put($"games/{gameId}/start");
        return response.IsSuccessStatusCode;
    }

    public static async Task<ServerAction?> GetNextAction(uint gameId, uint playerId)
    {
        HttpResponseMessage response = await ServerCall.Get($"games/{gameId}/players/{playerId}/action");

        if (response.IsSuccessStatusCode == false)
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            return null;
        }

        string actionJson = await response.Content.ReadAsStringAsync();
        ServerAction? action = JsonSerializer.Deserialize<ServerAction>(actionJson);

        return action;
    }

    public static async Task<bool> SendAction(uint gameId, uint playerId, ClientAction action)
    {
        HttpResponseMessage response = await ServerCall.PostJson($"games/{gameId}/player/{playerId}/action", action);
        return response.IsSuccessStatusCode;
    }
}
