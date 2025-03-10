using Microsoft.EntityFrameworkCore;

namespace Assignment3.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Product> Products { get; set; }

        public DbSet<Models.Users> Users { get; set; }
    }
    
}
