using CarStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CarStore
{
    [DependsOn(
        typeof(CarStoreEntityFrameworkCoreTestModule)
        )]
    public class CarStoreDomainTestModule : AbpModule
    {

    }
}