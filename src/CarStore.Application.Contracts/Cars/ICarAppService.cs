using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CarStore.Cars
{
    public interface ICarAppService :
        ICrudAppService<CarDTO, Guid, PagedAndSortedResultRequestDto, CreateUpdateCarDto>
    {
    }
}
