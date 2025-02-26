using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Infrastructure.Data.Configurations;

public class JunctionProductCategoriesConfiguration : IEntityTypeConfiguration<JunctionProductCategory>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JunctionProductCategory> builder)
    {
        builder.ToTable("JunctionProductCategories");

        builder.HasKey(pc => new { pc.ProductId, pc.CategoryId });

        builder.HasOne(pc => pc.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(pc => pc.ProductId);

        builder.HasOne(pc => pc.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(pc => pc.CategoryId);
    }
}
