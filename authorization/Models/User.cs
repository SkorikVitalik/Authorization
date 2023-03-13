using System.ComponentModel.DataAnnotations;

namespace authorization.Models;
public class User
{
    public Guid Id {get; set;}
    [Required]
    public string Login {get; set;} = null!;
    [Required]
    public string Email {get; set;} = null!;
    [Required]
    public string PasswordHash{get; set;} = null!;
    [Required]
    public string Salt {get; set;} = null!;
}

