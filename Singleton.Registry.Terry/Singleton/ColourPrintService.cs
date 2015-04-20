using System;

namespace TerrLuo.DesignPattern.Singleton.Registry.Terry
{
    public class ColourPrintService : PrintService
    {
        /// <summary>
        /// Client must use this member as key passed to PrintService,
        /// so that the static Constructor will be triggered due to member accessing for the first time
        /// and then this instance can be registered into dictionary.
        /// </summary>
        public static readonly string InstanceKey = typeof(ColourPrintService).FullName;

        static ColourPrintService()
        {
            new ColourPrintService().Register(InstanceKey);
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
