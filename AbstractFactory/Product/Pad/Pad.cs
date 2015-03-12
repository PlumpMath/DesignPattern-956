using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public abstract class Pad
    {
        public abstract Size Size { get; }

        public abstract int Weight { get; }

        public abstract decimal Price { get; }

        public abstract string System { get; }
    }
}
