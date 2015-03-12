using System;

namespace TerrLuo.DesignPattern.Composite
{
    public class NavigationTree
    {
        private readonly SqlDatabase _database = null;
        public NavigationTree(SqlDatabase database)
        {
            this._database = database;
            
            // Code to add database and its children to the Tree as tree nodes
        }

        /// <summary>
        /// Right-click on selected node 
        /// (here is simulating the right-click event)
        /// </summary>
        /// <param name="selectedNode"></param>
        public void OnRightClick(SqlTreeNode selectedNode)
        {
            if (selectedNode != null)
            {
                selectedNode.ShowContextMenu();
            }
        }

        /// <summary>
        /// Click the "Spage Usage" menu item 
        /// (here is simulating the click event: assuming this Space Usage menu item is in the Context Menu)
        /// </summary>
        /// <param name="selectedNode"></param>
        public void OnSpaceUsageMenuItemClick(SqlTreeNode selectedNode)
        {
            if (selectedNode != null)
            {
               int spaceUsage = selectedNode.GetSpaceUsage();
               // Code to display the space usage
            }
        }
    }
}
