using System;

namespace TerrLuo.DesignPattern.Adapter
{
    public class BinaryTree : Tree
    {
        public BinaryTree(string name, BinaryTreeNode topNode)
        {

        }

        public string Name { get; set; }

        /// <summary>
        /// Top node of the binary tree
        /// </summary>
        public BinaryTreeNode TopNode { get; set; }

        /// <summary>
        /// Get the depth of the tree
        /// </summary>
        /// <returns></returns>
        public override int GetDepth()
        {
            return GetNodeDepth(this.TopNode);
        }

        #region Private Method

        private int GetNodeDepth(BinaryTreeNode node)
        {
            int depth = 0;
            /*                
               To recrusively calculate the depth, something like:
             
                int leftDepth = GetNodeDepth(node.LeftNode);
                int rightDepth = GetNodeDepth(node.RightNode);
                depth  = Math.Max(leftDepth, rightDepth);
            */
            return depth;
        }

        #endregion

    }
}
