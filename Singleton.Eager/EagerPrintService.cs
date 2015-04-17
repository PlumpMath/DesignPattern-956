using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Singleton.Eager
{
    public sealed class EagerPrintService
    {
        // Item Queue for printing (Synchronized for thread safe)
        private readonly Queue _printItemQueue = Queue.Synchronized(new Queue());

        // Printers (IP Address)
        private readonly List<string> _printers = new List<string> { "172.18.125.1", "172.18.125.2", "172.18.125.3" };

        #region Singleton

        private static readonly EagerPrintService _printService = new EagerPrintService();

        private EagerPrintService()
        {
            // Code to initialize _printItemQueue and _printers can also be move here

            // Code to start the print loop job, something like: while (true) { DispatchPrint(); Sleep(5000); }

            // Some more code to do initialization
        }

        public static EagerPrintService Instance
        {
            get
            {
                return _printService;
            }
        }

        #endregion
        
        public void Print(object printItem)
        {
            this._printItemQueue.Enqueue(printItem);  
            Console.WriteLine("Eager print service has received: " + printItem.ToString());
        }

        private void DispatchPrint()
        {
            if (this._printItemQueue.Count > 0)
            {
                // Get the print item at the beginning of the queue
                Object printItem = this._printItemQueue.Dequeue();

                // Get a printer randomly
                string printer = this._printers[new Random().Next(0, 100) % this._printers.Count];

                // Code to request the printer to print the item 
                // ......
            }
        }
    }
}
