using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Tree.BinaryTree
{
    public class BinaryNode<T>
    {
        public T Value { get; set; }
        public int Height { get; set; }
        public BinaryNode<T> Left { get; set; }
        public BinaryNode<T> Right { get; set; }

    }
}
