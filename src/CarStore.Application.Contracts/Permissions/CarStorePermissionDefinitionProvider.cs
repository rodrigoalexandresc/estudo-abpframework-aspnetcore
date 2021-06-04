using CarStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CarStore.Permissions
{
    public class CarStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var carStoreGroup = context.AddGroup(CarStorePermissions.GroupName, L("Permission:CarStore"));

            var carsPermission = carStoreGroup.AddPermission(CarStorePermissions.Cars.Default, L("Permission:Cars"));
            carsPermission.AddChild(CarStorePermissions.Cars.Create, L("Permission:Cars.Create"));
            carsPermission.AddChild(CarStorePermissions.Cars.Edit, L("Permission:Cars.Edit"));
            carsPermission.AddChild(CarStorePermissions.Cars.Delete, L("Permission:Cars.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CarStoreResource>(name);
        }
    }
}
