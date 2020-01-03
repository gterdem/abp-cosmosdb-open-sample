using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AcmeApp.Web
{
    [Dependency(ReplaceServices = true)]
    public class AcmeAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AcmeApp";
    }
}
