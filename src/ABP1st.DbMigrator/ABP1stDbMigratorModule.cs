using ABP1st.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABP1st.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABP1stEntityFrameworkCoreModule),
    typeof(ABP1stApplicationContractsModule)
    )]
public class ABP1stDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
