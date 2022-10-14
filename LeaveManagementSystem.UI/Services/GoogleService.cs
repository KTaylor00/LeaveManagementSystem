using LeaveManagementSystem.UI.Models;
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
