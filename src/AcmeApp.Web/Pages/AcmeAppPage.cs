using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AcmeApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AcmeApp.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AcmeApp.Web.Pages.AcmeAppPage
     */
    public abstract class AcmeAppPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AcmeAppResource> L { get; set; }
    }
}
