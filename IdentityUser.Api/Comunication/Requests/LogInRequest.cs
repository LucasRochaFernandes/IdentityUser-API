using System.ComponentModel.DataAnnotations;

namespace UserIdentity.Api.Comunication.Requests;

public class LogInRequest
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}
