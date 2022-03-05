using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP1st.Data;

/* This is used if database provider does't define
 * IABP1stDbSchemaMigrator implementation.
 */
public class NullABP1stDbSchemaMigrator : IABP1stDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
