using Microsoft.EntityFrameworkCore;
using MyBasicBlazorApp.Models;

namespace MyBasicBlazorApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Category> Categories { get; set; } = null!;
    }
}
