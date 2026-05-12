
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mol.Api.Controllers;
using Mufi.Api.Controllers;
using Mufi.Core;
using Mufi.LiteDB;
using Scalar.AspNetCore;
using System.IO;
using System.Linq;

namespace Cadmus.Bricks.Api;

public class Program
{
    #region CORS
    private static void ConfigureCorsServices(IServiceCollection services,
        ConfigurationManager config)
    {
        string[] origins = ["http://localhost:4200"];

        IConfigurationSection section = config.GetSection("AllowedOrigins");
        if (section.Exists())
        {
            origins = section.AsEnumerable()
                .Where(p => !string.IsNullOrEmpty(p.Value))
                .Select(p => p.Value).ToArray()!;
        }

        services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
        {
            builder.AllowAnyMethod()
                .AllowAnyHeader()
                // https://github.com/aspnet/SignalR/issues/2110 for AllowCredentials
                .AllowCredentials()
                .WithOrigins(origins);
        }));
    }
    #endregion

    private static void ConfigureMol(IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddMolServices(options =>
        {
            options.Provider = MolDatabaseProvider.PostgreSQL;
            options.ConnectionString = configuration.GetConnectionString("MolDatabase");
            options.EnableAutoInitialization = configuration.GetSection("Mol")
                .GetValue<bool>("EnableAutoInitialization", true);
            options.InitializationDelaySeconds = configuration.GetSection("Mol")
                .GetValue<int>("InitializationDelaySeconds", 20);
        });
    }

    private static void ConfigureMufi(IServiceCollection services)
    {
        // configure MUFI service
        services.AddSingleton<IMufiRepository>(_ =>
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            return new LiteDBMufiRepository(
                new MufiRepositoryOptions
                {
                    Source = Path.Combine(path, "mufi.db")
                });
        });

        // configure services
        services.AddControllers()
            .AddApplicationPart(typeof(MolController).Assembly)
            .AddApplicationPart(typeof(MufiController).Assembly)
            .AddControllersAsServices();
    }

    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // configure CORS
        ConfigureCorsServices(builder.Services, builder.Configuration);

        // add response caching
        builder.Services.AddResponseCaching();

        // configure MOL
        ConfigureMol(builder.Services, builder.Configuration);

        // configure MUFI
        ConfigureMufi(builder.Services);

        // add HTTP client factory
        builder.Services.AddHttpClient();

        // add controllers and make sure MolController is included
        builder.Services.AddControllers()
            .AddApplicationPart(typeof(MolController).Assembly)
            .AddControllersAsServices();

        builder.Services.AddOpenApi();

        WebApplication app = builder.Build();

        // configure the HTTP request pipeline
        app.MapOpenApi();
        app.MapScalarApiReference(options => options.WithTitle("Cadmus Bricks Test API"));

        app.UseResponseCaching();
        app.UseAuthorization();
        app.UseCors("CorsPolicy");
        app.MapControllers();
        app.Run();
    }
}
