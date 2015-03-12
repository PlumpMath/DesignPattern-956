using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class IPad2 : Pad
    {
        public override Size Size { get { return new Size { Length = 150, Width = 100, Height = 5 }; } }

        public override int Weight { get { return 800; } }

        public override decimal Price { get { return 4000; } }

        public override string System { get { return "IOS 4"; } }
    }
}
