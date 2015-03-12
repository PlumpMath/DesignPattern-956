using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class WindowsPhone81 : Phone
    {
        public override Size Size { get { return new Size { Length = 80, Width = 35, Height = 4 }; } }

        public override int Weight { get { return 240; } }

        public override decimal Price { get { return 6000; } }

        public override string System { get { return "Windows 8.1"; } }
    }
}
