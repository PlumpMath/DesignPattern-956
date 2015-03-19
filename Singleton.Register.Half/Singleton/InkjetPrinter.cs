using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register.Half
{
    public class InkjetPrinter : Printer
    {
        static InkjetPrinter()
        {
            var instanceKey = typeof(LaserPrinter).FullName;
            new InkjetPrinter().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private InkjetPrinter()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
