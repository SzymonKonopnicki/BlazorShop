using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Application.Interfaces;

public interface IBlazorShopDbContext
{
    DbSet<Address> Addresses { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderItem> OrderItems { get; set; }
    DbSet<Person> Persons { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<ProductCategory> ProductCategories { get; set; }
    DbSet<ProductVariant> ProductVariants { get; set; }
    DbSet<JunctionProductCategory> JunctionProductCategories { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
