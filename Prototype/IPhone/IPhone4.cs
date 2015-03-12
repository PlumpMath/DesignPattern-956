using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Prototype
{
    public class IPhone4 : IPhone
    {
        public IPhone4()
        {
            this.Size   = new Size { Length = 70, Width = 35, Height = 5 };
            this.Weight = 200;
            this.Price  = 4000;

            /*
             * Load some more data from database, service, file ....
            */
        }

        public override IPhone Clone()
        {
            return (IPhone4)this.MemberwiseClone();
        }
    }
}
