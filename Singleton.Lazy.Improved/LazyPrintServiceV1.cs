using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Lazy.Improved
{
    public class LazyPrintServiceV1
    {
        private LazyPrintServiceV1()
        {
            this.PrintItems = new Queue();
        }

        private static LazyPrintServiceV1 Printer;
        private static object SyncRoot = new object();

        private Queue PrintItems;

        public static LazyPrintServiceV1 Instance
        {
            get
            {
                lock (SyncRoot)
                {
                    if (Printer == null)
                    {
                        Printer = new LazyPrintServiceV1();
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
