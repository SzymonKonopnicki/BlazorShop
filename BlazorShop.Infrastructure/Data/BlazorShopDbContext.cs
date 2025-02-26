using BlazorShop.Domain.Models;
using BlazorShop.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Infrastructure.Data;

public class BlazorShopDbContext : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Order> Orders{ get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
    public DbSet<JunctionProductCategory> JunctionProductCategories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlazorShopDb;Trusted_Connection=True;");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlazorShopDbContext).Assembly);

        modelBuilder.SeedProduct();
        modelBuilder.SeedProductVariant();
        modelBuilder.SeedProductCategory();
        modelBuilder.SeedJucationProductCategory();

        base.OnModelCreating(modelBuilder);
    }
}
