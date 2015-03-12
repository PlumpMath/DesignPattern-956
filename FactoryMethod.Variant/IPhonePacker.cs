using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    class IPhonePacker
    {
        /// <summary>
        /// Pack phone into a package according to its size
        /// </summary>
        public void PackPhone()
        {
            // Here is using "new", but it's could be more flexible instead of fixing. E.g. get a factory based on a parameter sothing like user-selected iPhone
            IPhoneFactory factory = new IPhone4Factory();

            IPhone iPhone = factory.Create();
            var volume = iPhone.Size.Length * iPhone.Size.Width * iPhone.Size.Height;

            /*
              Based on volume, do further process...
              Get a fitting package...
              Pack it into the package and record the package...
            */
        }
    }
}
