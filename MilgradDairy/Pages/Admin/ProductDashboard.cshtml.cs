using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages.Administrator;

public class ProductDashboard : PageModel
{
    public readonly AppDataContext Db;
    public ProductDashboard(AppDataContext db)
    {
        Db = db;
    }
    
    [BindProperty]
    public Product Product { get; set; }
    
    /*[BindProperty]
    public Action Find { get; set; }*/

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
    
    /*public IActionResult OnPost()
    {
        try
        {
            Product = Db.Products.FirstOrDefault(p => p.Name == Find);
            return Redirect("/Administrator/UpdateProduct");
        }
        catch (Exception e)
        {
            return Page();
        }
    }*/
}