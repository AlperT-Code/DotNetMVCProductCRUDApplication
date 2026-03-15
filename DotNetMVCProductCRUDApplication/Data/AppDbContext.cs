using Microsoft.EntityFrameworkCore;
using DotNetCrudApp.Models;

namespace DotNetCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
