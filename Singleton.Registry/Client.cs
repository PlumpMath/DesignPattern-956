using System;

namespace TerrLuo.DesignPattern.Singleton.Registry
{
    public class Client
    {
        public void Print(string printItem)
        {
            PrintService.GetInstance(typeof(ColourPrintService).FullName).Print(printItem);
        }
    }
}
