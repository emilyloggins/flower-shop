using System;

namespace flower_shop {
    public class Rose : Flower, IDescribable, IColor, IStemLength
    {
        public string Color { get; set; }
        public bool HasThorns { get; set; }
        public double StemLength { get; set; }
        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Rose";
        }
    }
}