using System.Threading.Tasks;

namespace ABP1st.Data;

public interface IABP1stDbSchemaMigrator
{
    Task MigrateAsync();
}
