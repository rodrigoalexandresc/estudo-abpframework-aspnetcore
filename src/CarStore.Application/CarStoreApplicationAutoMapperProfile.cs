using AutoMapper;
using CarStore.Cars;

namespace CarStore
{
    public class CarStoreApplicationAutoMapperProfile : Profile
    {
        public CarStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Car, CarDTO>();
            CreateMap<CreateUpdateCarDto, Car>();
        }
    }
}
