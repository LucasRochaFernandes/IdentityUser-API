using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserIdentity.Api.Comunication.Requests;
using UserIdentity.Api.Database.Entities;

namespace UserIdentity.Api.Services;

public class LogInService
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public LogInService(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IConfiguration configuration)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _configuration = configuration;
    }
    public async Task<string> Execute(LogInRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);

        if (user == null) {
            throw new Exception("UserName or Password is invalid");
        }

        var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, false, false);

        if (result.Succeeded is false)
        {
            throw new Exception("UserName or Password is invalid");
        }

        Claim[] claims =
        [
            new Claim("username", request.UserName),
            new Claim("userId", user.Id)
        ];

        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["secret_key_token"]));
        var signInCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            expires: DateTime.UtcNow.AddMinutes(30),
            claims: claims,
            signingCredentials: signInCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);   
    }
}
