using System;

namespace TerrLuo.DesignPattern.Singleton.Registry
{
    public class ColourPrintService : PrintService
    {
        /// <summary>
        /// Notice: here is public
        /// </summary>
        public ColourPrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Colour print service has received: " + printItem.ToString());
        }
    }
}
