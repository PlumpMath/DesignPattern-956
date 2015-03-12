using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class IPhone6 : IPhone
    {
        public IPhone6()
        {
            this.Size   = new Size { Length = 80, Width = 35, Height = 4 };
            this.Weight = 240;
            this.Price  = 6000;
        }
    }
}
