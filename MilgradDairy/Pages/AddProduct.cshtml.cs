using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class AddProduct : PageModel
{
    public readonly AppDataContext Db;
    
    [BindProperty]
    public Product Product { get; set; }

    public AddProduct(AppDataContext db)
    {
        Db = db;
    }
    
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            Db.Products.Add(Product);
            Db.SaveChanges();
            return Page();
        }
        else
        {
            return Page();
        }
    }
}