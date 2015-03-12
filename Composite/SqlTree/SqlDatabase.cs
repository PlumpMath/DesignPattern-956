using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Composite
{
    public class SqlDatabase : SqlTreeNode
    {
        public override void Add(SqlTreeNode node)
        {
            throw new InvalidCastException();
        }

        public override void Remove(SqlTreeNode node)
        {
            throw new InvalidCastException();
        }

        public override List<SqlTreeNode> GetChildren()
        {
            throw new InvalidCastException();
        }
        public override string Image { get { return "Database.jpg"; } }

        public override void ShowContextMenu()
        {
            // Code to show a database folder specific context menu
        }

        public override int GetSpaceUsage()
        {
            int spaceUsage = 0;
            // Code to get the database's space usage
            return spaceUsage;
        }
    }
}
