using AlQalem.DTOs.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AlQalem.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<AppUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(NewUserDTO user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new()
                {
                    UserName = user.userName,
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.password);
                if (result.Succeeded)
                {
                    return Ok("Registration successful.");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return BadRequest(ModelState);
                }
            }
            return BadRequest(ModelState);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUserDTO loginUser)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(loginUser.userName);
                if (user != null && await _userManager.CheckPasswordAsync(user, loginUser.password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    var roles = await _userManager.GetRolesAsync(user);
                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role)); 
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: _configuration["Jwt:Issuer"],
                        audience: _configuration["Jwt:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddHours(1),
                        signingCredentials: creds);

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                }
                return Unauthorized("Invalid username or password.");
            }
            return BadRequest("mohammed");
        }
    }
}
