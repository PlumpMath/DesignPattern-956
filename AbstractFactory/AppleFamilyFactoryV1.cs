using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public abstract class AppleFamilyFactoryV1 : AbstractFactory
    {
        public override Pad CreatePad()
        {
            return new IPad2();
        }

        public override Phone CreatePhone()
        {
            return new IPhone4();
        }
    }
}
