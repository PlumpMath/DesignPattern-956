using System;

namespace TerrLuo.DesignPattern.SimpleFactory
{
    public class IPhoneFactory
    {
        public static IPhone Create(string model)
        {
            switch(model)
            {
                case "IPhone4":
                    var iphone4 = new IPhone4();
                    // Some settings spcific for IPhone4...
                    // iphone4.SetMemory();
                    return iphone4;

                case "IPhone5":
                    var iphone5 = new IPhone5();
                    // Some settings spcific for IPhone5...
                    // iphone5.SetBattery();
                    return iphone5;

                case "IPhone6":
                    var iphone6 = new IPhone6();
                    // Some settings spcific for IPhone6...
                    // iphone6.SetHeadset();
                    return iphone6;
            }

            return new IPhone6();
        }
    }
}
