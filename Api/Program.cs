using System.Text;
using System.Text.Json.Serialization;
using Api.Extensions;
using Api.Interfaces;
using Api.Services;
using Domain.Extensions;
using Infrastructure.Database;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Api;

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
        services.AddApi(configuration);
        services.AddDomain(configuration);
        services.AddInfrastructure(configuration);

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwt =>
            {
                jwt.SaveToken = true;
                jwt.TokenValidationParameters =  configuration.Get<TokenValidationParameters>() ?? throw new ApplicationException($"Please set the TokenValidationParameters in the container");
            });

        services
            .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
        
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
        services
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        
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