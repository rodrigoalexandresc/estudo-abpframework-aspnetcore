namespace CarStore.Permissions
{
    public static class CarStorePermissions
    {
        public const string GroupName = "CarStore";

        public static class Cars
        {
            public const string Default = GroupName + ".Cars";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}