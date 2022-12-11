using System.Text;
using System.Text.Json.Serialization;
using AuthApp.Configuration;
using AuthApp.Extensions;
using AuthApp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Persistence.Database;
using Persistence.Extensions;
using ServiceCollectionExtensions = AuthApp.Extensions.ServiceCollectionExtensions;

namespace AuthApp;

public static class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        ConfigureServices(builder.Services, builder.Configuration);

        var app = builder.Build();
        RunMigrations(app);
        ConfigureApp(app);

        app.Run();
    }

    private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDi(configuration);
        services.AddPersistence(configuration);
        services.AddCustomAuthentication(configuration);

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllHeaders", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                }
            );
        });
        services.AddControllers()
            .AddJsonOptions(options =>
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options => options.CustomSchemaIds(type => type.ToString()));
    }

    private static void RunMigrations(WebApplication app) => app.RunMigrations();

    private static void ConfigureApp(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
    }
}