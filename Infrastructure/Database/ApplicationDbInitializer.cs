using Bogus;
using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Database;

public static class ApplicationDbInitializer
{
    static ApplicationDbInitializer()
    {
        GenerateProducts();
        GenerateUsers();
        GenerateRoles();
        GenerateUserRoles();
        GenerateCompanies();
    }

    private static void GenerateProducts()
    {
        var productFaker = new Faker<Product>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.Commerce.ProductName())
            .RuleFor(t => t.Description, f => f.Commerce.ProductDescription())
            .RuleFor(t => t.Price, f => f.Commerce.Price());

        Products = productFaker.GenerateBetween(30, 90).ToList();
    }

    private static void GenerateUsers()
    {
        IdentityUser user = new(); 
        const string password = "password";
        var hasher = new PasswordHasher<IdentityUser>();
        
        var userFaker = new Faker<IdentityUser>()
            .RuleFor(t => t.Id, f => Guid.NewGuid().ToString())
            .RuleFor(t => t.UserName, f => f.Person.UserName)
            .RuleFor(t => t.NormalizedUserName, f => f.Person.UserName)
            .RuleFor(t => t.Email, f => f.Person.Email)
            .RuleFor(t => t.NormalizedEmail, f => f.Person.Email)
            .RuleFor(t => t.PasswordHash, f => hasher.HashPassword(user, password))
            .RuleFor(t => t.EmailConfirmed, f => f.Random.Bool())
            .RuleFor(t => t.PhoneNumber, f => f.Person.Phone);
    
        Users = userFaker.GenerateBetween(30, 50);
    }
    
    private static void GenerateRoles()
    {
        Roles = new List<IdentityRole>()
        {
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = RoleType.Normal,
                NormalizedName = RoleType.Normal.ToUpper()
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = RoleType.Admin,
                NormalizedName = RoleType.Admin.ToUpper()
            }
        };
    }
    
    private static void GenerateUserRoles()
    {
        // Some users will be Admin, others will be Normal
        var random = new Random();

        UserRoles = Users
            .Select(user => new IdentityUserRole<string>
            {
                UserId = user.Id,
                RoleId = Roles.ElementAt(random.Next(2)).Id
            })
            .ToList();
    }

    private static void GenerateCompanies()
    {
        var companyFaker = new Faker<Company>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.Company.CompanyName())
            .RuleFor(t => t.Suffix, f => f.Company.CompanySuffix())
            .RuleFor(t => t.Bs, f => f.Company.Bs());
        
        // Companies
        Companies = companyFaker.GenerateBetween(20, 40);
    }
    
    public static IReadOnlyList<Product> Products { get; private set; }
    public static IReadOnlyList<IdentityUser> Users { get; private set; }
    public static IReadOnlyList<IdentityRole> Roles { get; private set; }
    public static IReadOnlyList<IdentityUserRole<string>> UserRoles { get; private set; }
    public static IReadOnlyList<Company> Companies { get; private set; }
}