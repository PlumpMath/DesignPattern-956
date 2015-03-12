using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class IPhone4 : Phone
    {
        public override Size Size { get { return new Size { Length = 70, Width = 35, Height = 5 }; } }

        public override int Weight { get { return 200; } }

        public override decimal Price { get { return 4000; } }

        public override string System { get { return "IOS 4"; } }
    }
}
