using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Registry.Half
{
    public class BlackWhitePrintService : PrintService
    {
        static BlackWhitePrintService()
        {
            var instanceKey = typeof(ColourPrintService).FullName;
            new BlackWhitePrintService().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private BlackWhitePrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Black & white print service has received: " + printItem.ToString());
        }
    }
}
