using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CarStore
{
    [Dependency(ReplaceServices = true)]
    public class CarStoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CarStore";
    }
}
