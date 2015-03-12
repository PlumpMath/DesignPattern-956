using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Hungry
{
    public class HungryPrinter
    {
        private HungryPrinter()
        {
        }

        private static readonly HungryPrinter Printer = new HungryPrinter();

        private Queue PrintItems = new Queue();

        public static HungryPrinter Instance
        {
            get
            {
                return Printer;
            }
        }

        public void Print(object printItem)
        {
            Console.WriteLine("Hungry Printer is printing: " + printItem.ToString());
        }
    }
}
