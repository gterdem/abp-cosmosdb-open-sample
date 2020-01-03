using AcmeApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AcmeApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AcmeAppEntityFrameworkCoreDbMigrationsModule),
        typeof(AcmeAppApplicationContractsModule)
        )]
    public class AcmeAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
