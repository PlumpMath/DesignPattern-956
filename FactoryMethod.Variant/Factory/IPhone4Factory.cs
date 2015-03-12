using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class IPhone4Factory : IPhoneFactory
    {
        public override IPhone Create()
        {
            var iphone4 = new IPhone4();

            // Some settings spcific for IPhone4...
            // iphone4.SetMemory();

            return iphone4;
        }
    }
}
