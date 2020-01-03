using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Volo.Abp.EntityFrameworkCore; //Not default, added for extension

namespace AcmeApp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AcmeAppMigrationsDbContextFactory : IDesignTimeDbContextFactory<AcmeAppMigrationsDbContext>
    {
        public AcmeAppMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AcmeAppMigrationsDbContext>()
                .UseCosmos(configuration.GetConnectionString("Default"));

            return new AcmeAppMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
