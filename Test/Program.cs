using System;

using TerrLuo.DesignPattern.Singleton.Register;

namespace TerrLuo.DesignPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Print("Do something...");
            Console.ReadLine();
        }
    }
}
