using CarStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CarStore.Permissions
{
    public class CarStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CarStorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CarStorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CarStoreResource>(name);
        }
    }
}
