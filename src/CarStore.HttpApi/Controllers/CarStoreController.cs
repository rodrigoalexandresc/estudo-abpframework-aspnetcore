using CarStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CarStore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CarStoreController : AbpController
    {
        protected CarStoreController()
        {
            LocalizationResource = typeof(CarStoreResource);
        }
    }
}