using System;
using System.Collections;

namespace TerrLuo.DesignPattern.Singleton.Eager
{
    public class EagerPrinter
    {
        private EagerPrinter()
        {
        }

        private static readonly EagerPrinter _printer = new EagerPrinter();

        private Queue PrintItems = new Queue();

        public static EagerPrinter Instance
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
