using System;

namespace TerrLuo.DesignPattern.Singleton.Register
{
    public class Client
    {
        public void Print(string printItem)
        {
            Printer.GetInstance(typeof(LaserPrinter).FullName).Print(printItem);
        }
    }
}
