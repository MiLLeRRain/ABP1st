using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABP1st.Web;

[Dependency(ReplaceServices = true)]
public class ABP1stBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABP1st";
}
