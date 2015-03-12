using System;

namespace TerrLuo.DesignPattern.Adapter
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(string name, BinaryTreeNode leftNode, BinaryTreeNode rightNode)
        {
            this.Name = name;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        public string Name { get; private set; }

        public BinaryTreeNode LeftNode { get; private set; }

        public BinaryTreeNode RightNode { get; private set; }
    }
}
