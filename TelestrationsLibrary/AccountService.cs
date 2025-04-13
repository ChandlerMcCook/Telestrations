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

    public async Task<HttpResponseMessage> CreateUser(string user, string pass)
    {
        var response = await _http.PostAsync("/users", new StringContent(JsonSerializer.Serialize(new { Username = user, Password = pass }), Encoding.UTF8, "application/json"));
        return response;
    }
}
