using System;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class Client
    {
        public void Print(string printItem)
        {
            PrintService.GetInstance(typeof(LaserPrintService).FullName).Print(printItem);
        }
    }
}
