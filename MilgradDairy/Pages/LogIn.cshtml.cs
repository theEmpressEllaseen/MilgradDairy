using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;
using Microsoft.EntityFrameworkCore;

namespace MilgradDairy.Pages;

public class LogIn : PageModel
{
    public readonly AppDataContext Db;
    
    [BindProperty]
    public TryUser TryUser { get; set; }

    public string LogInError;
    
    public LogIn(AppDataContext db)
    {
        Db = db;
    }
    
    public async Task<IActionResult> OnPost(TryUser tryUser)
    {
        var user = await Db.Users.SingleOrDefaultAsync(u => u.Email == tryUser.Email && u.Password == tryUser.Password);

        if (user != null) return RedirectToPage("Index");
        LogInError = "Incorrect details, please try again";
        return Page();
    }
}