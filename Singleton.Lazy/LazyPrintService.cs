using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy
{
    public class LazyPrintService
    {
        private LazyPrintService()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrintService _printer;

        private Queue PrintItems;

        public static LazyPrintService Instance
        {
            get
            {
                if ( _printer == null )
                {
                    _printer = new LazyPrintService();
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
