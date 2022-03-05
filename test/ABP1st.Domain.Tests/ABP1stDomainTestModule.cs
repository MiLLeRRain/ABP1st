using ABP1st.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABP1st;

[DependsOn(
    typeof(ABP1stEntityFrameworkCoreTestModule)
    )]
public class ABP1stDomainTestModule : AbpModule
{

}
