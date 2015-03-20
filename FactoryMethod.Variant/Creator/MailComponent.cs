using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class MailComponent : Component
    {
        private static ListViewItem _navigatorItem = new ListViewItem("Mail", "Mail.png");

        private static List<MenuItem> _menuItems = new List<MenuItem> 
        { 
            new MenuItem("New Email"), 
            new MenuItem("Delete"), 
            new MenuItem("Reply"), 
            new MenuItem("Forward") 
        };

        public override WorkArea CreateWorkArea()
        {
            return new MailWorkAreaFactory().Create();
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
