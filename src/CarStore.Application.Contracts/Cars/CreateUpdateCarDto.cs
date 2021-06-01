using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarStore.Cars
{
    public class CreateUpdateCarDto
    {
        [Required]
        [StringLength(128)]
        public string Model { get; set; }

        [Required]
        public CarType Type { get; set; } = CarType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime BuyDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }
    }
}
