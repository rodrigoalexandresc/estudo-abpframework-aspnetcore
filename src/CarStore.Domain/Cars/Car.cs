using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CarStore.Cars
{
    public class Car : AuditedAggregateRoot<Guid>
    {
        public string Model { get; set; }
        public CarType Type { get; set; }
        public DateTime BuyDate { get; set; }
        public float Price { get; set; }
    }
}
