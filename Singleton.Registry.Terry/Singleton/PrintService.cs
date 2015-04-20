using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Registry.Terry
{
    public class PrintService
    {
        private static readonly Dictionary<string, PrintService> _printServices = new Dictionary<string, PrintService>();

        /// <summary>
        /// Notice: Here is "protected", because when instantiating its children class, it will call base class' constructor
        /// </summary>
        protected PrintService()
        {
        }

        protected void Register(string key)
        {
            if (!_printServices.ContainsKey(key))
            {
                _printServices.Add(key, this);
            }
            else
            {
                _printServices[key] = this;
            }
        }
        
        public static PrintService GetInstance(string classFullName)
        {
            return _printServices[classFullName];
        }

        #region Case: Read key from Environment variables

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

        #endregion

        public virtual void Print(object printItem)
        {
            Console.WriteLine("Print service has received: " + printItem.ToString());
        }

    }
}
