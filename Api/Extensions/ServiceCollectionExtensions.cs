using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Api.Interfaces;
using Api.Services;
using Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace Api.Extensions;

public static class ServiceCollectionExtensions
{
    private const string Jwt = "Jwt";
    private const string JwtSecret = $"{Jwt}:Secret";
    private const string JwtIssuer = $"{Jwt}:Issuer";
    private const string JwtAudience = $"{Jwt}:Audience";

    public static void AddTokenValidation(this IServiceCollection services, IConfiguration configuration)
    {
        var secret = configuration[JwtSecret];
        if (string.IsNullOrEmpty(secret))
            throw new Exception("Secret is null. Please check your app-settings.json");
        
        var key = Encoding.ASCII.GetBytes(secret);
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidIssuer = configuration[JwtIssuer],
            ValidAudience = configuration[JwtAudience]
        };
        
        // services
        services.AddSingleton(validationParameters);
        services.Configure<Jwt>(configuration.GetSection(Jwt));
    }
    
    public static void AddSwaggerUi(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.CustomSchemaIds(type => type.ToString());
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "Authentication Authorization App", Version = "v1" });
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Scheme = JwtBearerDefaults.AuthenticationScheme.ToLowerInvariant(),
                In = ParameterLocation.Header,
                Name = "Authorization",
                BearerFormat = "JWT",
                Description = "Please enter a valid token"
            });
        });
    }

    public static void AddDi(this IServiceCollection services)
    {
        services.AddTransient<JwtSecurityTokenHandler>();
        services.AddTransient<ITokenGenerator, TokenGenerator>();
        services.AddTransient<ITokenValidator, TokenValidator>();
    }
}