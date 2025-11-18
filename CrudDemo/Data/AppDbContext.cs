using Microsoft.EntityFrameworkCore;
using CrudDemo.Models;

namespace CrudDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);  // 18 dígitos, 2 decimales

            base.OnModelCreating(modelBuilder);
        }
    }
}
