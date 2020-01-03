using System.Threading.Tasks;

namespace AcmeApp.Data
{
    public interface IAcmeAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
