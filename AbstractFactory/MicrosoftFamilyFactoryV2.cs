using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class MicrosoftFamilyFactoryV2 : AbstractFactory
    {
        public override Pad CreatePad()
        {
            return new Surface3();
        }

        public override Phone CreatePhone()
        {
            return new WindowsPhone75();
        }
    }
}
