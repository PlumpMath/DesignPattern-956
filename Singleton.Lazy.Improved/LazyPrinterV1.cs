using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy.Improved
{
    public class LazyPrinterV1
    {
        private LazyPrinterV1()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrinterV1 Printer;
        private static object SyncRoot = new object();

        private Queue PrintItems;

        public static LazyPrinterV1 Instance
        {
            get
            {
                lock (SyncRoot)
                {
                    if (Printer == null)
                    {
                        Printer = new LazyPrinterV1();
                    }
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
