using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Phone
{
    public class WindowsPhone75 : WindowsPhone
    {
        public WindowsPhone75()
        {
            this.Size   = new Size { Length = 75, Width = 35, Height = 4 };
            this.Weight = 220;
            this.Price  = 5000;
        }
    }
}
