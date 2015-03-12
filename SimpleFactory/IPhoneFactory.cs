using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.SimpleFactory
{
    public class IPhoneFactory
    {
        public IPhone Create(IPhoneModel model)
        {
            switch(model)
            {
                case IPhoneModel.IPhone4:
                    var iphone4 = new IPhone4();
                    // Some settings spcific for IPhone4...
                    // iphone4.SetMemory();
                    return iphone4;

                case IPhoneModel.IPhone5:
                    var iphone5 = new IPhone5();
                    // Some settings spcific for IPhone5...
                    // iphone5.SetBattery();
                    return iphone5;

                case IPhoneModel.IPhone6:
                    var iphone6 = new IPhone6();
                    // Some settings spcific for IPhone6...
                    // iphone6.SetHeadset();
                    return iphone6;
            }

            return new IPhone6();
        }
    }
}
