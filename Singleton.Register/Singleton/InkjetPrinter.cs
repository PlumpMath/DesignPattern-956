using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class InkjetPrinter : Printer
    {
        /// <summary>
        /// Notice: here is public
        /// </summary>
        public InkjetPrinter()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
