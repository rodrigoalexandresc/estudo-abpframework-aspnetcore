using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace CarStore.Brands
{
    public class BrandManager : DomainService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandManager(IBrandRepository brandRepository)
        {
            this._brandRepository = brandRepository;
        }

        public async Task<Brand> CreateAsync(
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string group)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingBrand = await _brandRepository.FindByNameAsync(name);
            if (existingBrand != null)
            {
                throw new BrandAlreadyExistsException(name);
            }

            return new Brand(
                GuidGenerator.Create(),
                name,
                birthDate,
                group
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Brand brand,
            [NotNull] string newName)
        {
            Check.NotNull(brand, nameof(brand));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingBrand = await _brandRepository.FindByNameAsync(newName);
            if (existingBrand != null && existingBrand.Id != brand.Id) 
            {
                throw new BrandAlreadyExistsException(newName);
            }

            brand.ChangeName(newName);
        }
    }
}
