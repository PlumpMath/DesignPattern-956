using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public abstract class Pad
    {
        public Size Size { get; set; }

        public int Weight { get; set; }

        public decimal Price { get; set; }
    }
}
