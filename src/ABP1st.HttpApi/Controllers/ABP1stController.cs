using ABP1st.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP1st.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABP1stController : AbpControllerBase
{
    protected ABP1stController()
    {
        LocalizationResource = typeof(ABP1stResource);
    }
}
