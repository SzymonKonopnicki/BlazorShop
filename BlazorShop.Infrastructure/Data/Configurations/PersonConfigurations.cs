using BlazorShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorShop.Infrastructure.Data.Configurations;

public class PersonConfigurations : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.Surname)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(25);
    }
}
