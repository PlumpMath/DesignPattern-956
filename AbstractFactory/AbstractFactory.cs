using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Phone CreatePhone();

        public abstract Pad CreatePad();
    }
}
