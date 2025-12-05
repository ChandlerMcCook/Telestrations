using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsUI.Network;
internal class ServerCall
{
    private static readonly string _serverBaseUrl = "https://localhost:7228";
    private static readonly HttpClient _client = new HttpClient() 
    {
        BaseAddress = new Uri(_serverBaseUrl) 
    };

    public static async Task<HttpResponseMessage> Get(string endpoint)
    {
        return await _client.GetAsync(endpoint);
    }

    public static async Task<HttpResponseMessage> Put(string endpoint)
    {
        return await _client.PutAsync(endpoint, null);
    }

    public static async Task<HttpResponseMessage> PostJson<T>(string endpoint,  T payload)
    {
        return await _client.PostAsJsonAsync(endpoint, payload);
    }

    public static async Task<HttpResponseMessage> PostImage(string endpoint, Bitmap image)
    {
        using MemoryStream ms = new MemoryStream();
        
        image.Save(ms, ImageFormat.Png);

        ByteArrayContent content = new ByteArrayContent(ms.ToArray());
        content.Headers.ContentType = new MediaTypeHeaderValue("image/png");

        return await _client.PostAsync(endpoint, content);
    }
}
