using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class UpdateProduct : PageModel
{
    public readonly AppDataContext Db;
    
    [BindProperty]
    public Product Product { get; set; }

    public UpdateProduct(AppDataContext db)
    {
        Db = db;
    }
    
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            Db.Products.Update(Product);
            Db.SaveChanges();
            return Page();
        }
        else
        {
            return Page();
        }
    }
}