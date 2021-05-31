using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CarStore.Cars
{
    public class CarAppService : CrudAppService<Car, CarDTO, Guid, PagedAndSortedResultRequestDto, CreateUpdateCarDto>
    {
        public CarAppService(IRepository<Car, Guid> repository) : base(repository)
        {
        }
    }
}
