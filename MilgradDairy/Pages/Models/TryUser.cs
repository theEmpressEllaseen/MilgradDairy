using System.ComponentModel.DataAnnotations;

namespace MilgradDairy.Pages.Models;

public class TryUser
{
    [Required(ErrorMessage="email is required")]
    public string Email { get; set; }
    
    [Required(ErrorMessage="password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}