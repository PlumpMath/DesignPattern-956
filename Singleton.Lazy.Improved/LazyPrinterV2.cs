using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy.Improved
{
    public class LazyPrinterV2
    {
        private LazyPrinterV2()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrinterV2 Printer;
        private static object SyncRoot = new object();

        private Queue PrintItems;

        public static LazyPrinterV2 Instance
        {
            get
            {
                // Double-check locking
                if (Printer == null)
                {
                    lock (SyncRoot)
                    {
                        if (Printer == null)
                        {
                            Printer = new LazyPrinterV2();
                        }
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
