using System;
using System.Linq;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Composite
{
    public class SqlTableFolder : SqlTreeNode
    {
        private readonly List<SqlTreeNode> _sqlTreeNodes = new List<SqlTreeNode>();

        public override void Add(SqlTreeNode node)
        {
            this._sqlTreeNodes.Add(node);
        }

        public override void Remove(SqlTreeNode node)
        {
            this._sqlTreeNodes.Remove(node);
        }

        public override List<SqlTreeNode> GetChildren()
        {
            return this._sqlTreeNodes;
        }

        public override string Image { get { return "TableFolder.jpg"; } }

        public override void ShowContextMenu()
        {
            // Code to show a database folder specific context menu
        }

        public override int GetSpaceUsage()
        {
            return this._sqlTreeNodes.Sum(p => p.GetSpaceUsage());
        }
    }
}
