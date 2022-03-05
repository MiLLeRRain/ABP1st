using Volo.Abp.Modularity;

namespace ABP1st;

[DependsOn(
    typeof(ABP1stApplicationModule),
    typeof(ABP1stDomainTestModule)
    )]
public class ABP1stApplicationTestModule : AbpModule
{

}
