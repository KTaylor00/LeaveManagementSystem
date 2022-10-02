using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.UI.Models;

public class AuthenticationModel
{
    [Required]
    [DataType(DataType.Text)]
    public string? Username { get; set; } = "test";

    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; } = "test";
}
