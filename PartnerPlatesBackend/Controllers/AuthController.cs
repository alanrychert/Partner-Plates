using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] ApplicationUser newUser)
    {
        var user = new IdentityUser { UserName = newUser.Username, Email = newUser.Email };
        var result = await _userManager.CreateAsync(user, newUser.Password);

        if (result.Succeeded)
        {
            return Ok(new { result = "User created successfully" });
        }

        return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] ApplicationUser userLoggingIn)
    {
        var user = await _userManager.FindByNameAsync(userLoggingIn.Username);
        if (user != null && await _userManager.CheckPasswordAsync(user, userLoggingIn.Password))
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return Ok(new { result = "User logged in successfully" });
        }
        return Unauthorized();
    }
}
