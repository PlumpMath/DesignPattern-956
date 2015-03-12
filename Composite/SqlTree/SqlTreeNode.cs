using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Composite
{
    public abstract class SqlTreeNode
    {
        public abstract void Add(SqlTreeNode node);
        public abstract void Remove(SqlTreeNode node);
        public abstract List<SqlTreeNode> GetChildren();

        /// <summary>
        /// Node image
        /// </summary>
        public abstract string Image { get; }

        /// <summary>
        /// Show context menu
        /// </summary>
        public abstract void ShowContextMenu();

        /// <summary>
        /// Get space usage (physical size)
        /// </summary>
        /// <returns></returns>
        public abstract int GetSpaceUsage();
        
    }
}
