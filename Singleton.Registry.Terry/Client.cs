using System;

namespace TerrLuo.DesignPattern.Singleton.Registry.Terry
{
    public class Client
    {
        public void Print(string printItem)
        {
            PrintService.GetInstance(ColourPrintService.InstanceKey).Print(printItem);
        }
    }
}
