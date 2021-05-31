using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CarStore.Cars
{
    public class CarDTO : AuditedEntityDto<Guid>
    {
        public string Model { get; set; }
        public CarType CarType { get; set; }
        public DateTime BuyDate { get; set; }
        public float Price { get; set; }
    }
}
