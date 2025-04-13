using System.ComponentModel.DataAnnotations.Schema;
using TelestrationsLibrary;

var http = new HttpClient() 
{
    BaseAddress = new Uri("https://localhost:7039/")
};

var accountService = new AccountService(http);

string? user = null;
string? pass = null;
while (user is null || pass is null)
{
    Console.WriteLine("Enter username:");
    user = Console.ReadLine();
    Console.WriteLine("Enter password:");
    pass = Console.ReadLine();
}

Console.WriteLine(await accountService.CreateUser(user, pass));