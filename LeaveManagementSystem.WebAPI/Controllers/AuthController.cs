using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LeaveManagementSystem.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IConfiguration config;

    public AuthController(IConfiguration config)
    {
        this.config = config;
    }

    public record AuthData(string? Username, string? Password);
    public record UserData(int Id, string Username);

    // POST api/Auth/token
    [HttpPost("token")]
    [AllowAnonymous]
    public ActionResult<string> Authenticate([FromBody] AuthData data)
    {
        var user = ValidateCredentials(data);

        if (user is null)
            return Unauthorized();

        string token = GenerateToken(user);

        return Ok(token);
    }

    private string GenerateToken(UserData user)
    {
        var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config.GetValue<string>("Auth:SecretKey")));

        var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new()
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Sub, user.Username)
        };

        var token = new JwtSecurityToken(
            config.GetValue<string>("Auth:Issuer"),
            config.GetValue<string>("Auth:Audience"),
            claims,
            DateTime.UtcNow,
            DateTime.UtcNow.AddHours(1),
            signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private static UserData? ValidateCredentials(AuthData data)
    {
        if (CompareValues(data.Username, "test") && CompareValues(data.Password, "test"))
        {
            return new UserData(1, data.Username!);
        }

        return null;
    }

    private static bool CompareValues(string? actual, string expected)
    {
        if (actual is not null)
        {
            if (actual.Equals(expected))
                return true;
        }

        return false;
    }
}
