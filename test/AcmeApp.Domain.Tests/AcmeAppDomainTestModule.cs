using AcmeApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AcmeApp
{
    [DependsOn(
        typeof(AcmeAppEntityFrameworkCoreTestModule)
        )]
    public class AcmeAppDomainTestModule : AbpModule
    {

    }
}