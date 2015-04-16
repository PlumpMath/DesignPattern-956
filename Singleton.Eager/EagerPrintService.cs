using System;
using System.Collections;

namespace TerrLuo.DesignPattern.Singleton.Eager
{
    public class EagerPrintService
    {
        private EagerPrintService()
        {
        }

        private static readonly EagerPrintService _printer = new EagerPrintService();

        private Queue PrintItems = new Queue();

        public static EagerPrintService Instance
        {
            get
            {
                return _printer;
            }
        }

        public void Print(object printItem)
        {
            Console.WriteLine("Eager Printer is printing: " + printItem.ToString());
        }
    }
}
