using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class IPhone6Factory : IPhoneFactory
    {
        public override IPhone Create()
        {
            var iphone6 = new IPhone6();

            // Some settings spcific for IPhone6...
            // iphone6.SetHeadset();

            return iphone6;
        }
    }
}
