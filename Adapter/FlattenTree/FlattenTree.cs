using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Adapter
{
    /// <summary>
    /// A tree-like flatten collection containing all its children items
    /// such as a top item and its children items, children items' children items, etc.
    /// </summary>
    public class FlattenTree : List<FlattenTreeItem>
    {
        private readonly List<FlattenTreeItem> _flattenTreeItems;
        public FlattenTree(List<FlattenTreeItem> flattenTreeItems)
        {
            this._flattenTreeItems = flattenTreeItems;
        }

        /// <summary>
        /// Get top item of the collection
        /// </summary>
        /// <returns></returns>
        public FlattenTreeItem GetTopItem()
        {
            return this._flattenTreeItems.Find(p => p.ParrentItem == null);
        }

        /// <summary>
        /// Get all the children items whose parrent is the specified item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public List<FlattenTreeItem> GetChildrenItems(FlattenTreeItem item)
        {
            return this._flattenTreeItems.FindAll(p => p.ParrentItem == item);
        }
    }
}
