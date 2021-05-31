using CarStore.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CarStore
{
    public class CarStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Car, Guid> _carRepository;

        public CarStoreDataSeederContributor(IRepository<Car, Guid> carRepository)
        {
            this._carRepository = carRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _carRepository.GetCountAsync() <= 0)
            {
                await _carRepository.InsertAsync(
                    new Car
                    {
                        Model = "Fiat Grande Punto",
                        Type = CarType.Hatchback,
                        BuyDate = new DateTime(2021,1,15),
                        Price = 26500.00f
                    }, 
                    autoSave: true);

                await _carRepository.InsertAsync(
                    new Car
                    {
                        Model = "Fiat Idea",
                        Type = CarType.SUV,
                        BuyDate = new DateTime(2018, 4, 2),
                        Price = 19900.00f
                    },
                    autoSave: true);
            }
        }
    }
}
