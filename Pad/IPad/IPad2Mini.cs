using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public class IPad2Mini : IPad
    {
        public IPad2Mini()
        {
            this.Size   = new Size { Length = 165, Width = 95, Height = 4 };
            this.Weight = 840;
            this.Price  = 6000;
        }
    }
}
