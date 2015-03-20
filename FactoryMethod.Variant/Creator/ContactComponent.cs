using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class ContactComponent : Component
    {
        private static ListViewItem _navigatorItem = new ListViewItem("Contact", "Contact.png");

        private static List<MenuItem> _menuItems = new List<MenuItem> 
        { 
            new MenuItem("New Contact"), 
            new MenuItem("Delete"), 
            new MenuItem("Address Cards"),       
            new MenuItem("Phone"),       
            new MenuItem("Categorize") 
        };

        public override WorkArea CreateWorkArea()
        {
            return new ContactWorkAreaFactory().Create();
        }

        public override ListViewItem NavigatorItem 
        { 
            get
            {
                return _navigatorItem;
            }
        }

        public override List<MenuItem> MenuItems 
        { 
            get
            {
                return _menuItems;
            }
        }
    }
}
