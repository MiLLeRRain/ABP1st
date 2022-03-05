using ABP1st.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABP1st.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ABP1stPageModel : AbpPageModel
{
    protected ABP1stPageModel()
    {
        LocalizationResourceType = typeof(ABP1stResource);
    }
}
