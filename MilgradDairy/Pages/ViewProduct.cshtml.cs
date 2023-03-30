using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class ViewProduct : PageModel
{
    public Product Product { get; set; }
    public readonly AppDataContext Db;

    public ViewProduct(AppDataContext db)
    {
        Db = db;
    }

    public IActionResult OnGet(string name)
    {
        Product = Db.Products.FirstOrDefault(p => p.Name == name);
        return Page();
    }
}