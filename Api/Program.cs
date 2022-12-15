using System.Text.Json.Serialization;
using Api.Configuration;
using Api.Middlewares;
using Domain.Models;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Api;

public static class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        ConfigureServices(builder.Services, builder.Configuration);

        var app = builder.Build();
        app.RunMigrations();

        ConfigureApp(app);

        app.Run();
    }
    
    private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDi();
        services.AddTokenValidation(configuration);
        services.AddInfrastructure(configuration);
        
        // Authorization & Authentication
        var tokenValidationParameters = services.GetTokenValidationParameters();
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .WithConfiguration(tokenValidationParameters);
        
        services.AddAuthorization(options =>
        {
            options.AddPolicy(PolicyType.Standard, policy =>
            {
                policy.RequireRole(RoleType.Normal, RoleType.Admin);
            });
            
            options.AddPolicy(PolicyType.Administrator, policy =>
            {
                policy.RequireRole(RoleType.Admin);
            });
            
            options.AddPolicy(PolicyType.SuperUser, policy =>
            {
                policy.RequireRole(RoleType.Admin);
                policy.RequireClaim("Super");
            });
        });

        services.AddSwaggerUi();
        services.AddEndpointsApiExplorer();
        services.AddCors(options =>
        {
            options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        });
        services
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
    }

    private static void ConfigureApp(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseMiddleware<JwtMiddleware>();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseCors("Open");
        app.MapControllers();
    }
}