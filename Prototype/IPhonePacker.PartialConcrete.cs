using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Prototype
{
    public class IPhonePartialConcretePacker
    {
        private IPhone _iPhone;

        public IPhonePartialConcretePacker(IPhone iPhone)
        {
            this._iPhone = iPhone;
        }

        /// <summary>
        /// Check if there's suitable package for specified test size in the specified package store
        /// </summary>
        /// <param name="testize"></param>
        /// <param name="boxStore"></param>
        /// <returns></returns>
        public bool ExistsSuitableBox(List<int> accessories, int boxStore)
        {
#warning Terry: Original code using prototype
            //var testIPhone = this._iPhone.Clone();
            //AddAccessories(testIPhone, accessories);

#warning Terry: New code: Specify the abstract IPhone, but when creating instance it's still using the concrete IPhone4. It cannot adapt to changes either.
            IPhone testIPhone = new IPhone4();
            AddAccessories(testIPhone, accessories);

            bool existsSuitableBox = false;
            /*
              Based on the specified test size and also some other properties of the iPhone, e.g. weight,
              search the specified package store
              check if there's suitable package the test phone
            */
            return existsSuitableBox;
        }

        /// <summary>
        /// Pack phone into a package according to its size
        /// </summary>
        public void PackPhone()
        {
            var volume = this._iPhone.Size.Length
                * this._iPhone.Size.Width
                * this._iPhone.Size.Height;

            /*
              Based on volume, do further process...
              Get a fitting package...
              Pack it into the package and record the package...
            */
        }

        /// <summary>
        /// Add accessories to iPhone
        /// </summary>
        /// <param name="iPhone"></param>
        /// <param name="accessories"></param>
        private void AddAccessories(IPhone iPhone, List<int> accessories)
        {
            /*
              Add accessories to iphone, such as:
                headset
                protection film
                protection cover
            */
        }
    }
}
