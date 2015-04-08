using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class AppleFamilyFactoryV2 : AbstractFactory
    {
        public override Pad CreatePad()
        {
            return new IPad2Mini();
        }

        public override Phone CreatePhone()
        {
            return new IPhone5();
        }
    }
}
