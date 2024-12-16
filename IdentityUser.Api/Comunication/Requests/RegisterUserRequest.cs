using System.ComponentModel.DataAnnotations;

namespace UserIdentity.Api.Comunication.Requests;

public class RegisterUserRequest
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string RePassword { get; set; }
}
