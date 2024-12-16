using IdentityUser.Api.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace IdentityUser.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult RegisterUser([FromBody] RegisterUserRequest request)
    {
        throw new NotImplementedException();
    }
}
