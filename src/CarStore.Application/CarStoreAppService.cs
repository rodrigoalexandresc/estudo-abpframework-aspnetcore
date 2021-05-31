using System;
using System.Collections.Generic;
using System.Text;
using CarStore.Localization;
using Volo.Abp.Application.Services;

namespace CarStore
{
    /* Inherit your application services from this class.
     */
    public abstract class CarStoreAppService : ApplicationService
    {
        protected CarStoreAppService()
        {
            LocalizationResource = typeof(CarStoreResource);
        }
    }
}
