using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Adapter
{
    public class TreeAdapter : Tree
    {
        private readonly FlattenTree _flattenTree;

        public TreeAdapter(FlattenTree flattenTree)
        {
            this._flattenTree = flattenTree;
        }

        /// <summary>
        /// Get the depth of the FlattenTree
        /// </summary>
        /// <returns></returns>
        public override int GetDepth()
        {
            var topItem = this._flattenTree.GetTopItem();
            return GetItemDepth(topItem);
        }

        #region Private Method

        /// <summary>
        /// Get the depth of item by 
        /// getting all its children items' depth, and finding the maximum
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private int GetItemDepth(FlattenTreeItem item)
        {            
            int depth = 0;
            var childrenItems = this._flattenTree.GetChildrenItems(item);
            foreach (var childrenItem in childrenItems)
            {
                int itemDepth = 1 + GetItemDepth(childrenItem);
                if ( itemDepth > depth )
                {
                    depth = itemDepth;
                }
            }
            return depth;
        }

        #endregion 
    }
}
