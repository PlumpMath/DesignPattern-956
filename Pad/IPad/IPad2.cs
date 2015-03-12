using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public class IPad2 : IPad
    {
        public IPad2()
        {
            this.Size   = new Size { Length = 150, Width = 100, Height = 5 };
            this.Weight = 800;
            this.Price  = 4000;
        }
    }
}
