using System;

namespace TerrLuo.DesignPattern.Singleton.Registry.Half
{
    public class ColourPrintService : PrintService
    {
        static ColourPrintService()
        {
            var instanceKey = typeof(ColourPrintService).FullName;
            new ColourPrintService().Register(instanceKey);
        }

        /// <summary>
        /// Still "private"
        /// </summary>
        private ColourPrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Colour print service has received: " + printItem.ToString());
        }
    }
}
