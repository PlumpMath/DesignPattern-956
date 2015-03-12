using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.GOF
{
    public abstract class Component
    {
        public abstract MainArea CreateMainArea();

        public abstract ListViewItem NavigatorItem { get; }

        public abstract List<MenuItem> MenuItems { get; }
    }
}
