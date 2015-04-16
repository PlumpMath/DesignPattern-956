using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class LaserPrintService : PrintService
    {
        /// <summary>
        /// Notice: here is public
        /// </summary>
        public LaserPrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
