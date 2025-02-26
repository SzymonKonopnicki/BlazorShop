using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Infrastructure.Data.Extensions;

public static class ModelBuilderExtensionProductVariant
{
    public static void SeedProductVariant(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductVariant>().HasData(
            new ProductVariant()
            {
                Id = 1,
                Size = "Small",
                Price = 9.99,
                ProductId = 1,
            },
            new ProductVariant()
            {
                Id = 2,
                Size = "Medium",
                Price = 19.99,
                ProductId = 1,
            },
            new ProductVariant()
            {
                Id = 3,
                Size = "Large",
                Price = 22.00,
                ProductId = 1,
            },
            new ProductVariant()
            {
                Id = 4,
                Size = "Small",
                Price = 7.98,
                ProductId = 2,
            },
            new ProductVariant()
            {
                Id = 5,
                Size = "Medium",
                Price = 19.97,
                ProductId = 2,
            },
            new ProductVariant()
            {
                Id = 6,
                Size = "Large",
                Price = 25.99,
                ProductId = 2,
            }
        );
    }
}
