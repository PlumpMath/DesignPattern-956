using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public abstract class Component
    {
        public abstract WorkArea CreateWorkArea();

        public abstract ListViewItem NavigatorItem { get; }

        public abstract List<MenuItem> MenuItems { get; }
    }
}
