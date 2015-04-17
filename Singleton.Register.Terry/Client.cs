using System;

namespace TerrLuo.DesignPattern.Singleton.Register.Terry
{
    public class Client
    {
        public void Print(string printItem)
        {
            PrintService.GetInstance(ColourPrintService.InstanceKey).Print(printItem);
        }
    }
}
