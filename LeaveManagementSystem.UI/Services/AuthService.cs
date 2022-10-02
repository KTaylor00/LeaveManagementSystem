using LeaveManagementSystem.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace LeaveManagementSystem.UI.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient client;
    private readonly ProtectedSessionStorage sessionStorage;
    private ProtectedBrowserStorageResult<string> token;

    public AuthService(HttpClient client, ProtectedSessionStorage sessionStorage)
    {
        this.client = client;
        this.sessionStorage = sessionStorage;
    }

    public async Task CreateToken(AuthenticationModel login)
    {
        var info = await client.PostAsJsonAsync("Auth/token", login);
        var token = await info.Content.ReadAsStringAsync();

        await sessionStorage.SetAsync("token", token);
    }

    public AuthenticationHeaderValue AuthHeaderValue()
    {
        return client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);
    }

    public async Task GetToken()
    {
        token = await sessionStorage.GetAsync<string>("token");
    }
}
