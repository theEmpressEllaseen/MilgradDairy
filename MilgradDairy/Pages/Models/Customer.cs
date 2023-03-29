using Microsoft.AspNetCore.Mvc;

namespace MilgradDairy.Pages.Models;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}