﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TerrLuo.DesignPattern.Singleton.Registry.Terry;

namespace TerrLuo.DesignPattern.UnitTest
{
    [TestClass]
    public class SingletonRegisterTerryTest
    {
        [TestMethod]
        public void TestSingletonRegisterHalf()
        {
            new Client().Print("Do something...");
        }
    }
}
