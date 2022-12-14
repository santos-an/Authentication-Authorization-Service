using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).IsRequired();
        
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Description).IsRequired();
        builder.Property(p => p.Price).IsRequired();

        builder.HasData(ApplicationDbInitializer.Products);
    }
}