using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register.Half
{
    public class InkjetPrintService : PrintService
    {
        static InkjetPrintService()
        {
            var instanceKey = typeof(LaserPrintService).FullName;
            new InkjetPrintService().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private InkjetPrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Laser Printer is printing: " + printItem.ToString());
        }
    }
}
