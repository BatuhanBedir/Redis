using Microsoft.EntityFrameworkCore;

namespace RedisApp.API.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                Name = "Pencil",
                Price = 100
            },
            new Product
            {
                Id = 2,
                Name = "Pencil 2",
                Price = 200

            }, new Product
            {
                Id = 3,
                Name = "Pencil 3",
                Price = 300

            });

        base.OnModelCreating(modelBuilder);
    }
}
