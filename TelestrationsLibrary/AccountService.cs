using System.Text;
using System.Text.Json;

namespace TelestrationsLibrary;
public class AccountService
{
    private readonly HttpClient _http;

    public AccountService(HttpClient http)
    {
        _http = http;
    }

    public void SignIn(string user, string pass)
    {
        Console.WriteLine("Signing in with user: " + user + " and pass: " + pass);
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
