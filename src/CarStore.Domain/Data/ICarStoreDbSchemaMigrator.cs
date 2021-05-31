using System.Threading.Tasks;

namespace CarStore.Data
{
    public interface ICarStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
