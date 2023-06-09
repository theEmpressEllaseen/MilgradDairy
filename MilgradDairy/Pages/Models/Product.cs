using System.ComponentModel.DataAnnotations;

namespace MilgradDairy.Pages.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage="Name is required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage="Image path is required")]
    public string Image { get; set; }
    
    [Required(ErrorMessage="Video path is required")]
    public string Video { get; set; }
    
    [Required(ErrorMessage="Description is required")]
    public string Description { get; set; }
    
    [Required(ErrorMessage="Alt text is required")]
    public string AltText { get; set; }

    [Required(ErrorMessage="Size is required")]
    public string Size { get; set; }
    
    [Required(ErrorMessage="Price is required")]
    public double Price { get; set; }
}