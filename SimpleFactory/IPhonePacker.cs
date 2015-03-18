using System;

namespace TerrLuo.DesignPattern.SimpleFactory
{
    class IPhonePacker
    {
        /// <summary>
        /// Pack phone into a package according to its size
        /// </summary>
        public void PackPhone()
        {            
            IPhone iPhone = IPhoneFactory.Create(IPhoneModel.IPhone5);

            var volume = iPhone.Size.Length 
                * iPhone.Size.Width 
                * iPhone.Size.Height;

            /*
              Based on volume, do further process...
              Get a fitting package...
              Pack it into the package and record the package...
            */
        }
    }
}
