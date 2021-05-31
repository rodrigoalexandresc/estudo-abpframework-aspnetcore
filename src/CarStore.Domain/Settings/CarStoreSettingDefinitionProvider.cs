using Volo.Abp.Settings;

namespace CarStore.Settings
{
    public class CarStoreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CarStoreSettings.MySetting1));
        }
    }
}
