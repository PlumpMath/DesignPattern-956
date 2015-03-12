using System;

namespace TerrLuo.DesignPattern.Adapter
{
    public class FlattenTreeItem
    {
        public FlattenTreeItem(int id, FlattenTreeItem parent)
        {
            this.ID = id;
            this.ParrentItem = parent;
        }

        public int ID { get; private set; }

        public FlattenTreeItem ParrentItem { get; private set; }
    }
}
