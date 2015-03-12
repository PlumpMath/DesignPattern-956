using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Phone
{
    public abstract class Phone
    {
        public Size Size { get; set; }

        public int Weight { get; set; }

        public decimal Price { get; set; }
    }
}
