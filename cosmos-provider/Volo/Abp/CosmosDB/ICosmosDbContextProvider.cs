using Volo.Abp.EntityFrameworkCore;

namespace Volo.Abp.CosmosDB
{
    public interface ICosmosDbContextProvider<out TDbContext>
        where TDbContext : AbpDbContext<TDbContext>
    {
        TDbContext GetDbContext();
    }
}
