using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public abstract class IPhoneFactory
    {
        public abstract IPhone Create();
    }
}
