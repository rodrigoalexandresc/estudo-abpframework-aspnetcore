using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace CarStore.Cars
{
    public class CarAppService_Tests : CarStoreApplicationTestBase
    {
        private readonly ICarAppService _carAppService;
        public CarAppService_Tests()
        {
            _carAppService = GetRequiredService<ICarAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Cars()
        {
            var result = await _carAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Model.Contains("Fiat"));
        }

        [Fact]
        public async Task Should_Create_A_Valid_Car()
        {
            const string modelName = "Renault Clio";

            var result = await _carAppService.CreateAsync(new CreateUpdateCarDto
            {
                Model = modelName,
                BuyDate = DateTime.Now,
                Price = 14500.00f,
                Type = CarType.Hatchback
            });

            result.Id.ShouldNotBe(Guid.Empty);
            result.Model.ShouldBe(modelName);
        }

        [Fact]
        public async Task Should_Not_Create_A_Car_Null_Model()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _carAppService.CreateAsync(new CreateUpdateCarDto
                {
                    Model = "",
                    Price = 50000f,
                    BuyDate = DateTime.Now,
                    Type = CarType.Sedan
                });
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(m => m == "Model"));
        }


    }
}
