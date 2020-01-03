using Volo.Abp.Modularity;

namespace AcmeApp
{
    [DependsOn(
        typeof(AcmeAppApplicationModule),
        typeof(AcmeAppDomainTestModule)
        )]
    public class AcmeAppApplicationTestModule : AbpModule
    {

    }
}