using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using LeaveManagementSystem.UI.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace LeaveManagementSystem.UI.Services;

public class GoogleService : IGoogleService
{
    private readonly HttpClient client;

    public GoogleService(HttpClient client)
    {
        this.client = client;
    }

    public async Task CreateEvent(object leave)
    {
        string? token = "";

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        await client.PostAsJsonAsync("asdfwoo123@gmail.com/events", leave);
    }
}
