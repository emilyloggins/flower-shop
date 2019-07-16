using System.Collections.Generic;
using System;

namespace flower_shop
{
    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Tulip> Tulips { get; set; }
        public List<Lilly> Lillies { get; set; }
        public List<Sunflower> Sunflowers { get; set; }

        // Any flower that goes in the mothers day arrangmenet must have a stem length property
        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>
        {
            new Rose() { PetalCount = 50, Price = 3.00 },
            new Sunflower() { PetalCount = 50, Price = 5.00 }
        };

        // Any flower in the birthday arrangement must have a Color property
        public List<IColor> BirthdayArrangement { get; set; } = new List<IColor>
        {
            new Rose() { Color = "Red", Price = 3.00 },
            new Tulip() { Color = "White", Price = 4.00 }
        };
    }
}