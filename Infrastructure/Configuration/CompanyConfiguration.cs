using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).IsRequired();
        
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Bs).IsRequired();
        builder.Property(p => p.Suffix).IsRequired();
        
        builder.HasData(ApplicationDbInitializer.Companies);
    }
}