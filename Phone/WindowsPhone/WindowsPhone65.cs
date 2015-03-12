using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Phone
{
    public class WindowsPhone65 : WindowsPhone
    {
        public WindowsPhone65()
        {
            this.Size   = new Size { Length = 70, Width = 35, Height = 5 };
            this.Weight = 200;
            this.Price  = 4000;
        }
    }
}
