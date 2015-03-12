using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class IPhone5 : Phone
    {
        public override Size Size { get { return new Size { Length = 75, Width = 35, Height = 4 }; } }

        public override int Weight { get { return 220; } }

        public override decimal Price { get { return 5000; } }

        public override string System { get { return "IOS 5"; } }
    }
}
