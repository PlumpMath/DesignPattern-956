using System;

namespace TerrLuo.DesignPattern.Singleton.Register.Terry
{
    public class Client
    {
        public void Print(string printItem)
        {
            Printer.GetInstance(LaserPrinter.InstanceKey).Print(printItem);
        }
    }
}
