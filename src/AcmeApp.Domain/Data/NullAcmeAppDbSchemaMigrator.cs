using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AcmeApp.Data
{
    /* This is used if database provider does't define
     * IAcmeAppDbSchemaMigrator implementation.
     */
    public class NullAcmeAppDbSchemaMigrator : IAcmeAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}