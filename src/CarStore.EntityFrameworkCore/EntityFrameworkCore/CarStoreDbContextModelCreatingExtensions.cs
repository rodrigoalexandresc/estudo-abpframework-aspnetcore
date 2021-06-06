using CarStore.Brands;
using CarStore.Cars;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CarStore.EntityFrameworkCore
{
    public static class CarStoreDbContextModelCreatingExtensions
    {
        public static void ConfigureCarStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Car>(b =>
            {
                b.ToTable(CarStoreConsts.DbTablePrefix + "Cars", CarStoreConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(p => p.Model).IsRequired().HasMaxLength(128);
            });

            builder.Entity<Brand>(b =>
            {
                b.ToTable(CarStoreConsts.DbTablePrefix + "Brands", CarStoreConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(BrandConsts.MaxNameLength);

                b.HasIndex(x => x.Name);
            });

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CarStoreConsts.DbTablePrefix + "YourEntities", CarStoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}