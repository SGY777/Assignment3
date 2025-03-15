using Assignment3.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Product> Products { get; set; }

        public DbSet<Models.Users> Users { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Explicitly setting the column type and precision for TotalPrice
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)");  // Precision of 18 and scale of 2
        }
    }
    
}
