using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CarStore.Data
{
    /* This is used if database provider does't define
     * ICarStoreDbSchemaMigrator implementation.
     */
    public class NullCarStoreDbSchemaMigrator : ICarStoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}