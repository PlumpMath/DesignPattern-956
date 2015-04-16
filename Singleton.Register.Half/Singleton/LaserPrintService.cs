using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register.Half
{
    public class LaserPrintService : PrintService
    {
        static LaserPrintService()
        {
            var instanceKey = typeof(LaserPrintService).FullName;
            new LaserPrintService().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private LaserPrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
