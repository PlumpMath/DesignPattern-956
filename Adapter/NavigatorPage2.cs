using System;

namespace TerrLuo.DesignPattern.Adapter
{
    public class NavigatorPage2
    {        
        public void AddNavigator(FlattenTree flattenTree)
        {
            // Navigator bound with FlattenTree with the help of TreeAdapter
            var treeAdapter = new TreeAdapter(flattenTree);
            var navigator = new Navigator(treeAdapter);

            /*
              Code to add navigator.
            */
        }
    }
}
