using System.ComponentModel.DataAnnotations;

namespace IdentityUser.Api.Comunication.Requests;

public class RegisterUserRequest
{
    [Required]
    public string UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }
    [Required]
    public DateOnly BirthDay { get; set; }
}
