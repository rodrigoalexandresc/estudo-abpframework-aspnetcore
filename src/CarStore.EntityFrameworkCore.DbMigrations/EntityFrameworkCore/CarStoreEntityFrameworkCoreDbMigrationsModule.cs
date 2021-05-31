using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CarStore.EntityFrameworkCore
{
    [DependsOn(
        typeof(CarStoreEntityFrameworkCoreModule)
        )]
    public class CarStoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CarStoreMigrationsDbContext>();
        }
    }
}
