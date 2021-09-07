using DSA.LinkedList.CSLL;
using DSA.LinkedList.SLL;
using DSA.Tree.BinaryTree.LinkedList;
using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SLL
            //var sll = new SingleLinkedList<int>();
            //var firstNode = sll.CreateSingleLinkedList(10);
            //var secondNode = sll.AddLast(20);
            //var thirdNode = sll.AddLast(30);

            //sll.AddFirst(5);

            //sll.AddAfter(thirdNode, 35);

            //sll.AddAfter(secondNode, 29);

            ////sll.DeleteNode(29);

            ////sll.DeleteNode(5);

            ////sll.DeleteNode(35);

            ////sll.DeleteNode(50);

            //sll.TraverseLinkedList();

            //var node = sll.SearchNode(29);

            //if(node != null)
            //{
            //    Console.WriteLine($"{node.GetHashCode()}");
            //}
            //else
            //{
            //    Console.WriteLine($"Node not found");
            //}
            #endregion

            #region CSLL
            //var csll = new CircularSingleLinkedList<int>();
            //csll.CreateCircularSingleLinkedList(10);

            //csll.AddFirst(5);
            //csll.AddFirst(1);
            //csll.AddFirst(0);

            //var node1 =  csll.AddLast(15);
            //csll.AddLast(20);

            //csll.AddAfter(node1, 18);

            //var searchNode = csll.SearchNode(15);

            //csll.DeleteNode(0);
            ////csll.DeleteNode()
            //csll.DeleteNode(20);
            ////csll.DeleteNode(18);

            //csll.TraverseList();

            #endregion

            #region Binary Tree Linked List
            //var binaryTree = new BinaryTreeByLinkedList<int>();
            //binaryTree.InsertNode(20);
            //binaryTree.InsertNode(100);
            //binaryTree.InsertNode(3);
            //binaryTree.InsertNode(50);
            //binaryTree.InsertNode(15);
            //binaryTree.InsertNode(250);
            //binaryTree.InsertNode(35);
            //binaryTree.InsertNode(222);

            //binaryTree.PreOrderTraversal(binaryTree.Root);

            //Console.WriteLine();

            //binaryTree.InOrderTraversal(binaryTree.Root);

            //Console.WriteLine();

            //binaryTree.PostOrderTravesal(binaryTree.Root);

            //Console.WriteLine();

            //binaryTree.LevelOrderTraversal(binaryTree.Root);

            //Console.WriteLine();

            //var searchNode = binaryTree.SearchNode(15);
            //Console.WriteLine(searchNode.Value);

            //Console.WriteLine();

            //binaryTree.DeleteNode(3);

            //binaryTree.LevelOrderTraversal(binaryTree.Root);


            #endregion
        }
    }
}
