using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Tree.BinaryTree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public int Height { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

    }
}
