using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class IPhone5Factory : IPhoneFactory
    {
        public override IPhone Create()
        {
            var iphone5 = new IPhone5();

            // Some settings spcific for IPhone5...
            // iphone5.SetBattery();

            return iphone5;
        }
    }
}
