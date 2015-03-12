using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public abstract class Phone
    {
        public abstract Size Size { get; }

        public abstract int Weight { get; }

        public abstract decimal Price { get; }

        public abstract string System { get; }
    }
}
