using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorShop.Infrastructure.Data.Configurations;

public class OrderConfigurations : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Paid)
            .IsRequired();

        builder.Property(x => x.OrderStatus)
            .IsRequired();

        builder.Property(x => x.DeliveryDate)
            .IsRequired();

        builder.HasMany(x => x.OrderItems) 
            .WithOne(x => x.Order) 
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);


        builder.HasOne(x => x.BuyerAddress)
            .WithOne()
            .HasForeignKey<Order>(x => x.BuyerAddressId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DeliveryAddress)
            .WithOne()
            .HasForeignKey<Order>(x => x.DeliveryAddressId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.BuyerPerson)
            .WithOne()
            .HasForeignKey<Order>(x => x.BuyerPersonId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DeliveryPerson)
            .WithOne()
            .HasForeignKey<Order>(x => x.DeliveryPersonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.Description)
            .HasMaxLength(200);
    }
}
