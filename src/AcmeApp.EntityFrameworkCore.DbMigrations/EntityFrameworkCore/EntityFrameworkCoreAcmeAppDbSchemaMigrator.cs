using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcmeApp.Data;
using Volo.Abp.DependencyInjection;

namespace AcmeApp.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAcmeAppDbSchemaMigrator 
        : IAcmeAppDbSchemaMigrator, ITransientDependency
    {
        private readonly AcmeAppMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAcmeAppDbSchemaMigrator(AcmeAppMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}