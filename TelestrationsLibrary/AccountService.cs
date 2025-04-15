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
}
