using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class Account : PageModel
{
    [BindProperty]
    public Customer Customer { get; set; }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            return Page();
        }
        else
        {
            return Page();
        }

    }
}