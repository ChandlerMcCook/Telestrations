using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsUI;
internal class ServerCall
{
    private static readonly string serverBaseUrl = "https://localhost:7228";

    public static async Task<HttpResponseMessage> MakeGetRequestAsync(string endpoint)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri(serverBaseUrl);
            HttpResponseMessage response = await client.GetAsync(endpoint);


            //HttpResponseMessage response = await client.GetAsync("https://dummy.restapiexample.com/api/v1/employees");


            return response;
        }
    }

    public static async Task<HttpResponseMessage> MakePostRequestAsync<T>(string endpoint, T payload)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri(serverBaseUrl);
            HttpResponseMessage response = await client.PostAsJsonAsync(endpoint, payload);
            return response;
        }
    }
}
