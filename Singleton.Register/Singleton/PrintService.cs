using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class PrintService
    {
        private static readonly Dictionary<string, PrintService> _printServices = new Dictionary<string,PrintService>();

        /// <summary>
        /// Notice: Printer as a base class has to know all its children classes: InkjetPrinter, LaserPrinter
        /// It doesn't sound good.
        /// </summary>
        static PrintService()
        {
            Register(new BlackWhitePrintService());
            Register(new ColourPrintService());
        }

        /// <summary>
        /// Here should be "protected", because when instantiating its children class, it will call base class' constructor
        /// </summary>
        protected PrintService()
        {
        }
        
        public static PrintService GetInstance(string key)
        {
            return _printServices[key];
        }

        /*
        
        /// <summary>
        /// Get instance according to the key stored in Environment variables
        /// </summary>
        public static PrintService Instance
        {
            get
            {
                string key = GetEnvKey();
                return _printServices[key];
            }
        }       
        
        /// <summary>
        /// Get key from Environment variables
        /// </summary>
        /// <returns></returns>
        private static string GetEnvKey()
        {
            var key = string.Empty;
            // Code to get key from Environment variables
            return key;
        }
        
        */

        public virtual void Print(object printItem)
        {
            Console.WriteLine("Print service has received: " + printItem.ToString());
        }

        private static void Register(PrintService printer)
        {
            var key = printer.GetType().FullName;
            if (!_printServices.ContainsKey(key))
            {
                _printServices.Add(key, printer);
            }
            else
            {
                _printServices[key] = printer;
            }
        }
    }
}
