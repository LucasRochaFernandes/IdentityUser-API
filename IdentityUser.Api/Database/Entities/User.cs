using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityUser.Api.Database.Entities;

[Table("Users")]
public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateOnly BirthDay{ get; set; }
}
