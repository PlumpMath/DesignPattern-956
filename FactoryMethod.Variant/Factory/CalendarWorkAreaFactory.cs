using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class CalendarWorkAreaFactory : WorkAreaFactory
    {
        public override WorkArea Create()
        {
            return new CalendarWorkArea();
        }
    }
}
