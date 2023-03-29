using System.ComponentModel.DataAnnotations;

namespace MilgradDairy.Pages.Models;

public class Customer
{
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
    [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{4,8}$", ErrorMessage="must include at least one digit and uppercase character")]
    public string Password { get; set; }
    
    [Required(ErrorMessage="confirm password is required")]
    [DataType(DataType.Password)]
    [Compare(otherProperty:"Password", ErrorMessage ="passwords must match")]
    public string ConfirmPassword { get; set; }
    
    [Required]
    public bool Accept { get; set; }

}