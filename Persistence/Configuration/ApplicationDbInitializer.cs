using Bogus;
using Domain.Models;

namespace Persistence.Configuration;

public static class ApplicationDbInitializer
{
    static ApplicationDbInitializer()
    {
        var productFaker = new Faker<Product>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.Commerce.ProductName())
            .RuleFor(t => t.Description, f => f.Commerce.ProductDescription())
            .RuleFor(t => t.Price, f => f.Commerce.Price());

        Todos = productFaker.GenerateBetween(30, 90).ToList();
    }
    
    public static IReadOnlyList<Product> Todos { get; }
}