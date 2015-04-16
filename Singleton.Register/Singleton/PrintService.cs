using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class PrintService
    {
        private static readonly Dictionary<string, PrintService> _printers = new Dictionary<string,PrintService>();

        /// <summary>
        /// Notice: Printer as a base class has to know all its children classes: InkjetPrinter, LaserPrinter
        /// It doesn't sound good.
        /// </summary>
        static PrintService()
        {
            Register(new InkjetPrintService());
            Register(new LaserPrintService());
        }

        /// <summary>
        /// Here should be "protected", because when instantiating its children class, it will call base class' constructor
        /// </summary>
        protected PrintService()
        {
        }
        
        public static PrintService GetInstance(string key)
        {
            return _printers[key];
        }

        /*
        
        /// <summary>
        /// Get instance according to the key stored in Environment variables
        /// </summary>
        public static Printer Instance
        {
            get
            {
                string key = GetEnvKey();
                return _printers[key];
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
            Console.WriteLine("Printer is printing: " + printItem.ToString());
        }

        private static void Register(PrintService printer)
        {
            var key = printer.GetType().FullName;
            if (!_printers.ContainsKey(key))
            {
                _printers.Add(key, printer);
            }
            else
            {
                _printers[key] = printer;
            }
        }
    }
}
