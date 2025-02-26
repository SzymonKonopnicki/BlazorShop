using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Infrastructure.Data.Extensions;

public static class ModelBuilderExtensionProductCategory
{
    public static void SeedProductCategory(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>().HasData(
            new ProductCategory()
            {
                Id = 1,
                Category = "Example",
            },
            new ProductCategory()
            {
                Id = 2,
                Category = "Red",
            },
            new ProductCategory()
            {
                Id = 3,
                Category = "Gift",
            },
            new ProductCategory()
            {
                Id = 4,
                Category = "Box"
            }
        );
    }
}
