using System;
using System.Collections.Generic;
using System.Text;
using ABP1st.Localization;
using Volo.Abp.Application.Services;

namespace ABP1st;

/* Inherit your application services from this class.
 */
public abstract class ABP1stAppService : ApplicationService
{
    protected ABP1stAppService()
    {
        LocalizationResource = typeof(ABP1stResource);
    }
}
