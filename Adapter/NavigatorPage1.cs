using System;

namespace TerrLuo.DesignPattern.Adapter
{
    public class NavigatorPage1
    {
        public void AddNavigator(BinaryTree binaryTree)
        {
            // Navigator bound with BinaryTree
            var navigator = new Navigator(binaryTree);
            
            /*
              Code to add navigator.
            */
        }
    }
}
