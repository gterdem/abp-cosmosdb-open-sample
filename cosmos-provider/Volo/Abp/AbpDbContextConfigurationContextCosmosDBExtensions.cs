using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Volo.Abp.EntityFrameworkCore
{
    public static class AbpDbContextConfigurationContextCosmosDBExtensions
    {
        public static DbContextOptionsBuilder<TContext> UseCosmos<TContext>(
            [NotNull] this DbContextOptionsBuilder<TContext> optionsBuilder,
            [NotNull] string connectionString,
            [CanBeNull] Action<CosmosDbContextOptionsBuilder> cosmosOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>)UseCosmos(
                (DbContextOptionsBuilder)optionsBuilder,
                connectionString,
                cosmosOptionsAction);

        public static DbContextOptionsBuilder UseCosmos(
            [NotNull] this DbContextOptionsBuilder optionsBuilder,
            [NotNull] string connectionString,
            [CanBeNull] Action<CosmosDbContextOptionsBuilder> cosmosOptionsAction = null)
        {
            var connStringParts = connectionString.ParseConnectionString();
            var accountEndpoint = connStringParts["AccountEndpoint"];
            var accountKey = connStringParts["AccountKey"];
            var databaseName = connStringParts["DatabaseName"];
            return optionsBuilder.UseCosmos(accountEndpoint: accountEndpoint, accountKey: accountKey, databaseName: databaseName, cosmosOptionsAction);
        }

        public static DbContextOptionsBuilder UseCosmos(
           [NotNull] this AbpDbContextConfigurationContext context,
           [CanBeNull] Action<CosmosDbContextOptionsBuilder> cosmosOptionsAction = null)
        {
            //context.ConnectionStringName = "AbpBackgroundJobs" hits all the time
            if (context.ExistingConnection != null)
            {
                var connStringParts = context.ExistingConnection.ConnectionString.ParseConnectionString();
                var accountEndpoint = connStringParts["AccountEndpoint"];
                var accountKey = connStringParts["AccountKey"];
                var databaseName = connStringParts["DatabaseName"];
                return context.DbContextOptions.UseCosmos(accountEndpoint: accountEndpoint, accountKey: accountKey, databaseName: databaseName, cosmosOptionsAction);
            }
            else
            {
                var connStringParts = context.ConnectionString.ParseConnectionString();
                var accountEndpoint = connStringParts["AccountEndpoint"];
                var accountKey = connStringParts["AccountKey"];
                var databaseName = connStringParts["DatabaseName"];
                return context.DbContextOptions.UseCosmos(accountEndpoint: accountEndpoint, accountKey: accountKey, databaseName: databaseName, cosmosOptionsAction);
            }
        }

        internal static Dictionary<string, string> ParseConnectionString(this string connString)
        {
            return connString.Split(';')
            .Select(t => t.Split(new char[] { '=' }, 2))
            .ToDictionary(t => t[0].Trim(), t => t[1].Trim(), StringComparer.InvariantCultureIgnoreCase);
        }
    }
}
