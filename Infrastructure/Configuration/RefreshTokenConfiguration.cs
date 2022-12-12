﻿using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).IsRequired();
        
        builder.Property(t => t.UserId).IsRequired();
        builder.HasOne<IdentityUser>(t => t.User)
            .WithMany()
            .HasForeignKey(u => u.UserId);

        builder.Property(t => t.JwtId).IsRequired();
        builder.Property(t => t.Token).IsRequired();
        
        builder.Property(t => t.IsRevoked).IsRequired();
        builder.Property(t => t.IsUsed).IsRequired();
        
        builder.Property(t => t.Created).IsRequired();
        builder.Property(t => t.ExpiryDate).IsRequired();
    }
}