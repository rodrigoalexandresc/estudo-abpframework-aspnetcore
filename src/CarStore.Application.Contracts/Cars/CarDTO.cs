using System;
using Volo.Abp.Application.Dtos;

namespace CarStore.Cars
{
    public class CarDTO : AuditedEntityDto<Guid>
    {
        public string Model { get; set; }
        public CarType Type { get; set; }
        public DateTime BuyDate { get; set; }
        public float Price { get; set; }
    }
}
