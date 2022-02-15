using DSA.Graph;
using DSA.LinkedList.CSLL;
using DSA.LinkedList.SLL;
using DSA.Practice.ArrayStrings;
using DSA.Practice.DivideAndConquer;
using DSA.Practice.GreedyAlgorithm;
using DSA.Practice.LinkedList;
using DSA.Practice.Recursion;
using DSA.Tree;
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

            #region Binary Search Tree

            //var bst = new BinarySearchTree();
            //bst.CreateBST(100);
            //bst.InsertNode(80);
            //bst.InsertNode(200);
            //bst.InsertNode(300);
            //bst.InsertNode(150);
            //bst.InsertNode(90);
            //bst.InsertNode(70);
            //bst.InsertNode(400);
            //bst.InsertNode(250);
            //bst.InsertNode(50);
            //bst.InsertNode(40);
            //bst.InsertNode(60);

            //bst.LevelOrderTraversal(bst.Root);

            //bst.DeleteNode(200);

            //Console.WriteLine();
            //bst.LevelOrderTraversal(bst.Root);

            //bst.DeleteNode(60);

            //Console.WriteLine();
            //bst.LevelOrderTraversal(bst.Root);

            //bst.DeleteNode(70);

            //Console.WriteLine();
            //bst.LevelOrderTraversal(bst.Root);


            #endregion

            //IsUnique isUnique = new IsUnique();
            //Console.WriteLine(isUnique.HasUniqueCharacters("abcd"));
            //Console.WriteLine(isUnique.HasUniqueCharacters("abcdd"));


            //CheckPermutation permutation = new CheckPermutation();
            //Console.WriteLine(permutation.IsAPermutation("abca  dd", "abd ca d"));
            //Console.WriteLine(permutation.IsAPermutation("abcd ", "ab cd"));

            //URLify url = new URLify();
            //Console.WriteLine(url.ConvertUrl("Mr John Smith    ", 13));

            //PalindromePermutation pp = new PalindromePermutation();
            //Console.WriteLine(pp.IsPalindromePermutation("tacocat"));
            //Console.WriteLine(pp.IsPalindromePermutation("ar crca a"));

            //StringCompression sc = new StringCompression();
            //Console.WriteLine(sc.CompressString("aabcccccaaaAbCCZZZ"));

            //RemoveDups rd = new RemoveDups();
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddLast(2);
            //list.AddLast(3);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(2);
            //list.AddLast(1);

            //rd.Print(list);
            //rd.RemoveDupItem(list.First);
            //Console.WriteLine("");
            //rd.Print(list);


            //LinkedList<int> list1 = new LinkedList<int>();
            //list1.AddFirst(1);
            //list1.AddLast(2);
            //list1.AddLast(3);
            //list1.AddLast(4);
            //list1.AddLast(5);

            //KthElement ke = new KthElement();
            //Console.WriteLine(ke.KthElementFromLast(list1.First, 2));

            //var activitySelection = new ActivitySelection();
            //var activities = new List<Activity>
            //{
            //    new Activity
            //    {
            //        Start = 0,
            //        End = 6
            //    },
            //    new Activity
            //    {
            //        Start = 3,
            //        End = 4
            //    },
            //    new Activity
            //    {
            //        Start = 1,
            //        End = 2
            //    },
            //    new Activity
            //    {
            //        Start = 5,
            //        End = 8
            //    },
            //    new Activity
            //    {
            //        Start = 5,
            //        End = 7
            //    },
            //    new Activity
            //    {
            //        Start = 8,
            //        End = 9
            //    }
            //};

            //var list = activitySelection.SelectActivities(activities);
            //foreach(var item in list)
            //{
            //    Console.WriteLine($"Start: {item.Start}, End: {item.End}");
            //}

            //var coinChangeProblem = new CoinChangeProblem();
            //var count = coinChangeProblem.CalculateMinChange(new int[] { 1, 2, 5, 10, 20, 50, 100, 500, 1000 }, 121);
            //Console.WriteLine(count);

            //var fks = new FractionalKnapSack();
            //var items = new List<Item>()
            //{
            //    new Item
            //    {
            //        Weight = 20,
            //        Value = 100
            //    },
            //    new Item
            //    {
            //        Weight = 30,
            //        Value = 120
            //    },
            //    new Item
            //    {
            //        Weight = 10,
            //        Value = 60
            //    }
            //};

            //var total = fks.Calculate(items, 29);

            //Console.WriteLine(total);

            //var nf = new NumberFactor();
            //Console.WriteLine(nf.FactorsOfN(6));

            //MergeKSortedLists mergeKSortedLists = new MergeKSortedLists();

            //List<SingleNode<int>> nodes = new List<SingleNode<int>>();

            //var node = new SingleNode<int>()
            //{
            //    Value = 1,
            //    Next = new SingleNode<int>()
            //    {
            //        Value = 4,
            //        Next = new SingleNode<int>()
            //        {
            //            Value = 5
            //        }
            //    }
            //};


            //nodes.Add(node);

            //node = new SingleNode<int>()
            //{
            //    Value = 1,
            //    Next = new SingleNode<int>()
            //    {
            //        Value = 3,
            //        Next = new SingleNode<int>()
            //        {
            //            Value = 4
            //        }
            //    }
            //};

            //nodes.Add(node);

            //node = new SingleNode<int>()
            //{
            //    Value = 2,
            //    Next = new SingleNode<int>()
            //    {
            //        Value = 6
            //    }
            //};

            //nodes.Add(node);

            //var result = mergeKSortedLists.MergeKLists(nodes.ToArray());

            //while(result != null)
            //{
            //    Console.Write(result.Value);
            //    result = result.Next;
            //}

            //var sn = new SwapNodes();
            //SingleNode<int> node = new SingleNode<int>();
            //node.Value = 1;
            //node.Next = new SingleNode<int>
            //{
            //    Value = 2,
            //    Next = new SingleNode<int>
            //    {
            //        Value = 3,
            //        Next = new SingleNode<int>
            //        {
            //            Value = 4,
            //            Next = null
            //        }
            //    }
            //};

            //sn.SwapPairs(node);


            //var arr = new int[3, 2];

            DisjointQuickFind dsQF = new DisjointQuickFind(10);

            dsQF.Union(1, 2);
            dsQF.Union(2, 5);
            dsQF.Union(5, 6);
            dsQF.Union(6, 7);
            dsQF.Union(3, 8);
            dsQF.Union(8, 9);

            Console.WriteLine(dsQF.Connected(1, 5));//true
            Console.WriteLine(dsQF.Connected(5, 7));//true
            Console.WriteLine(dsQF.Connected(4, 9));//false

            dsQF.Union(9, 4);
            Console.WriteLine(dsQF.Connected(4, 9));//true

        }
    }
}
