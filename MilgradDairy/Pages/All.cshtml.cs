using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class All : PageModel
{
    public List<Product> Products { get; set; }

    public readonly AppDataContext Db;

    public All(AppDataContext db)
    {
        Db = db;
    }
    
    public void OnGet()
    {
        Products = Db.Products.ToList();
    }
}