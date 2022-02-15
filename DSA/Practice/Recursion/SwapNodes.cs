using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA.LinkedList.SLL;

namespace DSA.Practice.Recursion
{
    internal class SwapNodes
    {
        internal SingleNode<int> SwapPairs(SingleNode<int> head)
        {
            if(head == null || head.Next == null)
            {
                return head;
            }

            var firstNode = head;
            var secondNode = head.Next;

            firstNode.Next = SwapPairs(secondNode.Next);
            secondNode.Next = firstNode;

            return secondNode;
        }
    }
}
