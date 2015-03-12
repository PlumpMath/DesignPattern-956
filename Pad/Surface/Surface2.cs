using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public class Surface2 : Surface
    {
        public Surface2()
        {
            this.Size   = new Size { Length = 150, Width = 100, Height = 5 };
            this.Weight = 800;
            this.Price  = 4000;
        }
    }
}
