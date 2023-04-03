using System.ComponentModel.DataAnnotations;

namespace MilgradDairy.Pages.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage="first name is required")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage="last name is required")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage="email is required")]
    [EmailAddress(ErrorMessage="email is invalid")]
    public string Email { get; set; }
    
    [Required(ErrorMessage="password is required")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage="must be at least 8 characters")]
    [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage="must have at least: 8 digits, one digit, one, lowercase, one uppercase")]
    public string Password { get; set; }
    
    [Required(ErrorMessage="confirm password is required")]
    [DataType(DataType.Password)]
    [Compare(otherProperty:"Password", ErrorMessage ="passwords must match")]
    public string ConfirmPassword { get; set; }
    
    [Required]
    public bool Accept { get; set; }
}