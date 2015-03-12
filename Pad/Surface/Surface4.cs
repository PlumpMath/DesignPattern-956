using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public class Surface4 : Surface
    {
        public Surface4()
        {
            this.Size   = new Size { Length = 165, Width = 95, Height = 4 };
            this.Weight = 840;
            this.Price  = 6000;
        }
    }
}
