using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.GOF
{
    public class CalendarComponent : Component
    {
        private static ListViewItem _navigatorItem = new ListViewItem("Calendar", "Calendar.png");

        private static List<MenuItem> _menuItems = new List<MenuItem> 
        { 
            new MenuItem("New Appointment"), 
            new MenuItem("New Meeting"), 
            new MenuItem("Today"), 
            new MenuItem("Next 7 Days"),            
            new MenuItem("Day"),            
            new MenuItem("Work Week"),            
            new MenuItem("Week") 
        };

        public override MainArea CreateMainArea()
        {
            return new MailMainArea();
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
