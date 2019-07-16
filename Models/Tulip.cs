using System;

namespace flower_shop
{
    public class Tulip : Flower, IDescribable, IColor, IStemLength
    {
        public string Color { get; set; }
        public double StemLength { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Tulip";
        }
    }
}