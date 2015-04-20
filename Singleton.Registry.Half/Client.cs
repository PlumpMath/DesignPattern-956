using System;

namespace TerrLuo.DesignPattern.Singleton.Registry.Half
{
    public class Client
    {
        public void Print(string printItem)
        {
            PrintService.GetInstance("TerrLuo.DesignPattern.Singleton.Registry.Half.LaserPrinter").Print(printItem);
        }
    }
}
