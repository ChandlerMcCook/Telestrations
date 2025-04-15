using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TelestrationsLibrary;

public class GameManager
{
    private readonly HttpClient _http;

    public GameManager(HttpClient http)
    {
        _http = http;
    }

    public async Task<HttpResponseMessage> GetUsers()
    {
        var response = await _http.GetAsync("/users");
        return response;
    }

    public async Task<HttpResponseMessage> CreateUser(string user, string pass)
    {
        var response = await _http.PostAsync("/users", new StringContent(JsonSerializer.Serialize(new { Username = user, Password = pass }), Encoding.UTF8, "application/json"));
        return response;
    }

    public async Task<HttpResponseMessage> GetGames()
    {
        var response = await _http.GetAsync("/games");
        return response;
    }

    public async Task<HttpResponseMessage> CreateGame(string gameName, int hostId)
    {
        var response = await _http.PostAsync("/games", new StringContent(JsonSerializer.Serialize(new { GameName = gameName, HostId = hostId }), Encoding.UTF8, "application/json"));
        return response;
    }

    //public async Task<IEnumerable<HttpResponseMessage>> DeleteGame(int gameId)
    //{
    //    var responseGamePlayers = await _http.DeleteAsync($"/games/{gameId}/players");
    //    var responseGame = await _http.DeleteAsync($"/games/{gameId}");
    //    return IEnumerable<HttpResponseMessage>(responseGamePlayers, responseGame);
    //}

    public async Task<HttpResponseMessage> GetPlayersForGame(int gameId)
    {
        var response = await _http.GetAsync($"/games/{gameId}/players");
        return response;
    }
}
