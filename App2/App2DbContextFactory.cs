using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace App2;

internal class App2DbContextFactory
    : IDesignTimeDbContextFactory<App2DbContext>
{
    public App2DbContext CreateDbContext(string[] args)
    {
        App2EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<App2DbContext>()
            .UseNpgsql(configuration.GetConnectionString("Default"));

        return new App2DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
