using Microsoft.AspNetCore.Mvc;
using UserIdentity.Api.Comunication.Requests;
using UserIdentity.Api.Services;

namespace UserIdentity.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly RegisterUserService _registerUserService;

    public UserController(RegisterUserService registerUserService)
    {
        _registerUserService = registerUserService;
    }

    [HttpPost]
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
}
