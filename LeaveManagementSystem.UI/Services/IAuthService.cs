using LeaveManagementSystem.UI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Net.Http.Headers;

namespace LeaveManagementSystem.UI.Services;

public interface IAuthService
{
    AuthenticationHeaderValue AuthHeaderValue();
    Task CreateToken(AuthenticationModel login);
    Task GetToken();
}
