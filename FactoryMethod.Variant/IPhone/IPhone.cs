using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public abstract class IPhone
    {
        public Size Size { get; set; }

        public int Weight { get; set; }

        public decimal Price { get; set; }
    }
}
