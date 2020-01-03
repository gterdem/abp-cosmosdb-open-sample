using System;
using System.Collections.Generic;
using System.Text;
using AcmeApp.Localization;
using Volo.Abp.Application.Services;

namespace AcmeApp
{
    /* Inherit your application services from this class.
     */
    public abstract class AcmeAppAppService : ApplicationService
    {
        protected AcmeAppAppService()
        {
            LocalizationResource = typeof(AcmeAppResource);
        }
    }
}
