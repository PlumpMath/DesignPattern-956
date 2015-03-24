using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class Outlook
    {
        /// <summary>
        /// Load out look components
        /// </summary>
        public void LoadComponents()
        {
            // Find all outlook components
            List<Component> components = FindComponents();

            // Load main members of each component into outlook
            foreach (var component in components)
            {
                // Fill Menu & Navigator 
                FillMenu(component.MenuItems);
                FillNavigator(component.NavigatorItem);

                // Fill Work Area
                var workArea = component.CreateWorkArea();
                FillWorkArea(workArea);
            }
        }

        /// <summary>
        /// Find all outlook components
        /// (
        ///     here could be very flexible: 
        ///     you could check the component plugin folder 
        ///     to load all component DLLs into APP domain
        /// )
        /// </summary>
        /// <returns></returns>
        private List<Component> FindComponents()
        {
            return new List<Component>
            {
                new MailComponent(),
                new CalendarComponent(),
                new ContactComponent(),
            };
        }


        private void FillMenu(List<MenuItem> menuItems)
        {
            // ...
        }


        private void FillNavigator(ListViewItem navigatorItem)
        {
            // ...
        }


        private void FillWorkArea(WorkArea workArea)
        {
            // ...
        }
    }
}
