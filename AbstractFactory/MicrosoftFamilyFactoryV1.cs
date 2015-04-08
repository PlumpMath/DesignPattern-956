using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class MicrosoftFamilyFactoryV1 : AbstractFactory
    {
        public override Pad CreatePad()
        {
            return new Surface2();
        }

        public override Phone CreatePhone()
        {
            return new WindowsPhone65();
        }
    }
}
