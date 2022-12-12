using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Api.Interfaces;
using Api.Services;
using Domain.Models;
using Microsoft.IdentityModel.Tokens;

namespace Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtConfig>(configuration.GetSection("JwtConfig"));
        
        services.AddTransient<ITokenGenerator, TokenGenerator>();
        services.AddTransient<ITokenValidator, TokenValidator>();
        services.AddTransient<JwtSecurityTokenHandler>();

        var secret = configuration["JwtConfig:Secret"];
        if (string.IsNullOrEmpty(secret))
            throw new ApplicationException("Please set a secret in app-settings.json");
        
        var key = Encoding.ASCII.GetBytes(secret);
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            RequireExpirationTime = false
        };

        services.AddSingleton(validationParameters);
        
        return services;
    }

    public static IServiceCollection AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        

        return services;
    }
}