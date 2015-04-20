using System;

namespace TerrLuo.DesignPattern.Singleton.Registry.Terry
{
    public class BlackWhitePrintService : PrintService
    {
        /// <summary>
        /// Client must use this member as key passed to PrintService,
        /// so that the static Constructor will be triggered due to member accessing for the first time
        /// and then this instance can be registered into dictionary.
        /// </summary>
        public static readonly string InstanceKey = typeof(ColourPrintService).FullName;

        static BlackWhitePrintService()
        {
            new BlackWhitePrintService().Register(InstanceKey);
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
