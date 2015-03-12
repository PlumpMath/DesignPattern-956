using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy
{
    public class LazyPrinter
    {
        private LazyPrinter()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrinter Printer;

        private Queue PrintItems;

        public static LazyPrinter Instance
        {
            get
            {
                if ( Printer == null )
                {
                    Printer = new LazyPrinter();
                }

                return Printer;
            }
        }

        public void Print(object printItem)
        {
            Console.WriteLine("Lazy Printer is printing: " + printItem.ToString());
        }
    }
}
