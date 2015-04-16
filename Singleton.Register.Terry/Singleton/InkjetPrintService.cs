using System;

namespace TerrLuo.DesignPattern.Singleton.Register.Terry
{
    public class InkjetPrintService : PrintService
    {
        /// <summary>
        /// Client must use this member as key passed to Printer,
        /// so that the static Constructor will be triggered due to member accessing for the first time
        /// and then this instance can be registered into dictionary.
        /// </summary>
        public static readonly string InstanceKey = typeof(LaserPrintService).FullName;

        static InkjetPrintService()
        {
            new InkjetPrintService().Register(InstanceKey);
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
