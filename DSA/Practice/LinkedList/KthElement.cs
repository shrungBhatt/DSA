using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.LinkedList
{
    internal class KthElement
    {
        internal int KthElementFromLast(LinkedListNode<int> node, int k)
        {
            var stack = new Stack<int>();
            while(node != null)
            {
                stack.Push(node.Value);
                node = node.Next;
            }

            for(int i=0; i<k-1; i++)
            {
                stack.Pop();
            }

            return stack.Peek();
        }
    }
}
