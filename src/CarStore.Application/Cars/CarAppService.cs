using CarStore.Permissions;
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
    public class CarAppService : CrudAppService<Car, CarDTO, Guid, PagedAndSortedResultRequestDto, CreateUpdateCarDto>, ICarAppService
    {
        public CarAppService(IRepository<Car, Guid> repository) : base(repository)
        {
            GetPolicyName = CarStorePermissions.Cars.Default;
            GetListPolicyName = CarStorePermissions.Cars.Default;
            CreatePolicyName = CarStorePermissions.Cars.Create;
            UpdatePolicyName = CarStorePermissions.Cars.Edit;
            DeletePolicyName = CarStorePermissions.Cars.Delete;
        }
    }
}
