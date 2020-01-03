using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AcmeApp.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AcmeAppHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AcmeAppConsoleApiClientModule : AbpModule
    {
        
    }
}
