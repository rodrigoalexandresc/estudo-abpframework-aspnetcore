using Volo.Abp.Modularity;

namespace CarStore
{
    [DependsOn(
        typeof(CarStoreApplicationModule),
        typeof(CarStoreDomainTestModule)
        )]
    public class CarStoreApplicationTestModule : AbpModule
    {

    }
}