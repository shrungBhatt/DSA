using DSA.LinkedList.SLL;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var sll = new SingleLinkedList<int>();
            var firstNode = sll.CreateSingleLinkedList(10);
            var secondNode = sll.AddLast(20);
            var thirdNode = sll.AddLast(30);

            sll.AddAfter(firstNode, 15);

            sll.AddFirst(5);

            sll.AddAfter(thirdNode, 35);

            sll.AddAfter(secondNode, 29);

            sll.TraverseLinkedList();

            var node = sll.SearchNode(29);

            Console.WriteLine($"{node.GetHashCode()}");
        }
    }
}
