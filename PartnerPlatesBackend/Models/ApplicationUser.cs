using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Nickname { get; set; }
}
