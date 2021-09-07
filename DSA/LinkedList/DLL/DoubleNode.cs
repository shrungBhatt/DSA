using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinkedList.DLL
{
    public class DoubleNode<T>
    {
        public DoubleNode<T> Next { get; set; }
        public DoubleNode<T> Previous { get; set; }
        public T Value { get; set; }
        
    }
}
