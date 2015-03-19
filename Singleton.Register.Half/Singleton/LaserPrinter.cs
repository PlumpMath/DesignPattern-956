using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register.Half
{
    public class LaserPrinter : Printer
    {
        static LaserPrinter()
        {
            var instanceKey = typeof(LaserPrinter).FullName;
            new LaserPrinter().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private LaserPrinter()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
