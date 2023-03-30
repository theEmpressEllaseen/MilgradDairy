using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class CreateAccount : PageModel
{
    public readonly AppDataContext Db;
    
    [BindProperty]
    public User User { get; set; }

    public CreateAccount(AppDataContext db)
    {
        Db = db;
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            Db.Users.Add(User);
            Db.SaveChanges();
            return Page();
        }
        else
        {
            return Page();
        }
    }
}