using System;

namespace TerrLuo.DesignPattern.Singleton.Registry
{
    public class BlackWhitePrintService : PrintService
    {
        /// <summary>
        /// Notice: here is public
        /// </summary>
        public BlackWhitePrintService()
        {
        }

        public override void Print(object printItem)
        {
            Console.WriteLine("Black & white print service has received: " + printItem.ToString());
        }
    }
}
