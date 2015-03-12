using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Adapter
{
    public class Navigator
    {
        private readonly Tree _tree;

        public Navigator(Tree tree)
        {
            this._tree = tree;
        }

        public int GetMaxWidth()
        {
            int depth = this._tree.GetDepth();
            int maxWidth = 20 * depth;
            return maxWidth;
        }
    }
}
