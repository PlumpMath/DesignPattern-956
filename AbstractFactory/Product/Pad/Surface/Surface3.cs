using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class Surface3 : Pad
    {
        public override Size Size { get { return new Size { Length = 145, Width = 95, Height = 4 }; } }

        public override int Weight { get { return 820; } }

        public override decimal Price { get { return 8000; } }

        public override string System { get { return "Windows 8.0"; } }
    }
}
