using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class IPad2Mini : Pad
    {
        public override Size Size { get { return new Size { Length = 165, Width = 95, Height = 4 }; } }

        public override int Weight { get { return 840; } }

        public override decimal Price { get { return 6000; } }

        public override string System { get { return "IOS 4"; } }
    }
}
