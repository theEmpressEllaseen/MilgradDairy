using Microsoft.AspNetCore.Mvc.RazorPages;
using MilgradDairy.Pages.Models;

namespace MilgradDairy.Pages;

public class Butter : PageModel
{
    public Product butter { get; set; }
    public void OnGet()
    {
        butter = new Product
        {
            Name = "butter",
            Image = "~/images/butter.png",
            Video = "~/video/cat.mp4",
            Description =
            "rich butter, available with or without salt. perfect for spreading on toast or for baking delicious cakes.",
            Size = "450g",
            Price = "£2.80"
        };
    }
}