using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class MailWorkAreaFactory : WorkAreaFactory
    {
        public override WorkArea Create()
        {
            return new MailWorkArea();
        }
    }
}
