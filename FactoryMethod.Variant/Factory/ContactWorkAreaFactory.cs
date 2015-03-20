using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class ContactWorkAreaFactory : WorkAreaFactory
    {
        public override WorkArea Create()
        {
            return new ContactWorkArea();
        }
    }
}
