using CarStore.Brands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CarStore.EntityFrameworkCore.Brands
{
    public class EfCoreBrandRepository
        : EfCoreRepository<CarStoreDbContext, Brand, Guid>,
        IBrandRepository
    {
        public EfCoreBrandRepository(IDbContextProvider<CarStoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Brand> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(brand => brand.Name == name);
        }

        public async Task<List<Brand>> GetListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    brand => brand.Name.Contains(filter)
                )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
