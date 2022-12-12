using Bogus;
using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Database;

public static class ApplicationDbInitializer
{
    private static readonly IdentityUser User = new();
    private const string Password = "password";

    static ApplicationDbInitializer()
    {
        var productFaker = new Faker<Product>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.Commerce.ProductName())
            .RuleFor(t => t.Description, f => f.Commerce.ProductDescription())
            .RuleFor(t => t.Price, f => f.Commerce.Price());

        Products = productFaker.GenerateBetween(30, 90).ToList();

        var hasher = new PasswordHasher<IdentityUser>();
        var userFaker = new Faker<IdentityUser>()
            .RuleFor(t => t.Id, f => Guid.NewGuid().ToString())
            .RuleFor(t => t.UserName, f => f.Person.UserName)
            .RuleFor(t => t.NormalizedUserName, f => f.Person.UserName)
            .RuleFor(t => t.Email, f => f.Person.Email)
            .RuleFor(t => t.NormalizedEmail, f => f.Person.Email)
            .RuleFor(t => t.PasswordHash, f => hasher.HashPassword(User, Password))
            .RuleFor(t => t.EmailConfirmed, f => f.Random.Bool())
            .RuleFor(t => t.PhoneNumber, f => f.Person.Phone);

        IdentityUsers = userFaker.GenerateBetween(30, 50);

        var userId = IdentityUsers.ElementAt(0).Id;
        RefreshTokens = new List<RefreshToken>()
        {
            new()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                IsUsed = true,
                IsRevoked = true,
                Created = DateTime.Now,
                ExpiryDate = DateTime.Today,
                JwtId = "jwt 1",
                Token = "token 1",
            },
            new()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                IsUsed = false,
                IsRevoked = false,
                Created = DateTime.Now,
                ExpiryDate = DateTime.Today,
                JwtId = "jwt 2",
                Token = "token 2"
            }
        };
    }

    public static IReadOnlyList<Product> Products { get; }
    public static IReadOnlyList<IdentityUser> IdentityUsers { get; }
    public static IReadOnlyList<RefreshToken> RefreshTokens { get; }
}