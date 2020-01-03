using AcmeApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AcmeApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AcmeAppController : AbpController
    {
        protected AcmeAppController()
        {
            LocalizationResource = typeof(AcmeAppResource);
        }
    }
}