using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
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

    public static async Task<bool> CreateGame(string gameName, Player host)
    {
        HttpResponseMessage response = await ServerCall.PostJson($"/games?gameName={gameName}", host);

        return response.IsSuccessStatusCode;
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
}
