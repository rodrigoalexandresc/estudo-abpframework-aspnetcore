using CarStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CarStore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CarStoreEntityFrameworkCoreDbMigrationsModule),
        typeof(CarStoreApplicationContractsModule)
        )]
    public class CarStoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
