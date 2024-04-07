using Microsoft.EntityFrameworkCore;

namespace IntexII_Project_4_2.Models
{
    public class IntexProjectDbContext : DbContext
    {
        public IntexProjectDbContext (DbContextOptions<IntexProjectDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
