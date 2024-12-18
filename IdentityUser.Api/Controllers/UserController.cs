using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserIdentity.Api.Comunication.Requests;
using UserIdentity.Api.Services;

namespace UserIdentity.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly RegisterUserService _registerUserService;
    private readonly LogInService _logInService;

    public UserController(
        RegisterUserService registerUserService,
        LogInService logInService)
    {
        _registerUserService = registerUserService;
        _logInService = logInService;
    }

    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserRequest request)
    {

        var result = await _registerUserService.Execute(request);

        if (result.Succeeded) {
            return Created(string.Empty, result);
        } else
        {
            throw new Exception("Unable to register a user");
        }
    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> LogInUser([FromBody] LogInRequest request)
    {
        var result = await _logInService.Execute(request);
        return Ok(new { token = result });
    }

    [HttpGet("acesso")]
    [Authorize]
    public IActionResult TestingAccess()
    {
        return Ok("Acesso Permitido");
    }
}
