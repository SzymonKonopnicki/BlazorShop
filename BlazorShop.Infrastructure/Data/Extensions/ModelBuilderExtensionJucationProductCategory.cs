using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BlazorShop.Infrastructure.Data.Extensions;

public static class ModelBuilderExtensionJucationProductCategory
{
    public static void SeedJucationProductCategory(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JunctionProductCategory>().HasData(
            new { ProductId = 1, CategoryId = 1 },
            new { ProductId = 1, CategoryId = 2 },
            new { ProductId = 1, CategoryId = 3 },
            new { ProductId = 2, CategoryId = 1 },
            new { ProductId = 2, CategoryId = 3 },
            new { ProductId = 2, CategoryId = 4 }
        );
    }
}
