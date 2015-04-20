using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TerrLuo.DesignPattern.Singleton.Registry.Half;

namespace TerrLuo.DesignPattern.UnitTest
{
    [TestClass]
    public class SingletonRegisterHalfTest
    {
        [TestMethod]
        public void TestSingletonRegisterHalf()
        {
            new Client().Print("Do something...");
        }
    }
}
