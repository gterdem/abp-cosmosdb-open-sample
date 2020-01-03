using AcmeApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AcmeApp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AcmeAppPageModel : AbpPageModel
    {
        protected AcmeAppPageModel()
        {
            LocalizationResourceType = typeof(AcmeAppResource);
        }
    }
}