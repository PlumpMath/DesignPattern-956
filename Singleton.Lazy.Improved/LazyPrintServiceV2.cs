using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy.Improved
{
    public class LazyPrintServiceV2
    {
        private LazyPrintServiceV2()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrintServiceV2 Printer;
        private static object SyncRoot = new object();

        private Queue PrintItems;

        public static LazyPrintServiceV2 Instance
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
                            Printer = new LazyPrintServiceV2();
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
