using System;

namespace TerrLuo.DesignPattern.Singleton.Register.Half
{
    public class Client
    {
        public void Print(string printItem)
        {
            Printer.GetInstance("TerrLuo.DesignPattern.Singleton.Register.Half.LaserPrinter").Print(printItem);
        }
    }
}
