using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Pad
{
    public class Surface3 : Surface
    {
        public Surface3()
        {
            this.Size   = new Size { Length = 145, Width = 95, Height = 4 };
            this.Weight = 820;
            this.Price  = 5000;
        }
    }
}
