using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Infrastructure.Data.Extensions;

public static class ModelBuilderExtensionProduct
{
    public static void SeedProduct(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                Name = "First product.",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Photo = "C:\\Users\\Pictures"
            },
            new Product()
            {
                Id = 2,
                Name = "Second product.",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Photo = "C:\\Users\\Pictures"
            }
        );
    }
}
