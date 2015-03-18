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

        private static LazyPrinter _printer;

        private Queue PrintItems;

        public static LazyPrinter Instance
        {
            get
            {
                if ( _printer == null )
                {
                    _printer = new LazyPrinter();
                }

                return _printer;
            }
        }

        public void Print(object printItem)
        {
            Console.WriteLine("Lazy Printer is printing: " + printItem.ToString());
        }
    }
}
