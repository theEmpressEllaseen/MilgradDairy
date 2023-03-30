using Microsoft.EntityFrameworkCore;

namespace MilgradDairy.Pages.Models;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
}