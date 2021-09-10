using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Tree.BinaryTree.LinkedList
{
    public class BinaryTreeByLinkedList<T>
    {
        public TreeNode<T> Root { get; set; }

        public BinaryTreeByLinkedList()
        {
            Root = null;
        }

        //Pre-order traversal
        public void PreOrderTraversal(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write($" {root.Value} ");

            PreOrderTraversal(root.Left);

            PreOrderTraversal(root.Right);
        }

        //In-order traversal
        public void InOrderTraversal(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.Left);

            Console.Write($" {root.Value} ");

            InOrderTraversal(root.Right);
        }

        //Post-order traversal
        public void PostOrderTravesal(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderTravesal(root.Left);

            PostOrderTravesal(root.Right);

            Console.Write($" {root.Value} ");
        }

        //Level-order traversal
        public void LevelOrderTraversal(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(root);
            while (nodes.Count != 0)
            {
                var node = nodes.Dequeue();
                Console.Write($" {node.Value} ");

                if (node.Left != null)
                    nodes.Enqueue(node.Left);

                if (node.Right != null)
                    nodes.Enqueue(node.Right);

            }

        }

        //Search node
        public TreeNode<T> SearchNode(T value)
        {
            if (Root == null)
            {
                throw new Exception("The root cannot be empty");
            }

            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(Root);
            while (nodes.Count != 0)
            {
                var node = nodes.Dequeue();
                if (EqualityComparer<T>.Default.Equals(node.Value, value))
                {
                    return node;
                }
                else
                {
                    if (node.Left != null)
                        nodes.Enqueue(node.Left);

                    if (node.Right != null)
                        nodes.Enqueue(node.Right);
                }
            }

            throw new Exception("The node not found");
        }


        //Insert node
        public TreeNode<T> InsertNode(T value)
        {
            var newNode = new TreeNode<T>() { Value = value };

            if (Root == null)
            {
                Root = newNode;
                return Root;
            }

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node.Left == null)
                {
                    node.Left = newNode;
                    return node.Left;
                }
                else if (node.Right == null)
                {
                    node.Right = newNode;
                    return node.Right;
                }
                else
                {
                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
                }
            }

            throw new Exception("Error occurred while inserting new node");
        }

        //Delete node
        public void DeleteNode(T value)
        {
            if (Root == null)
            {
                throw new Exception("The tree is not initialized or does not contain any nodes");
            }

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (EqualityComparer<T>.Default.Equals(node.Value, value))
                {
                    var deepestNode = GetDeepestNode();
                    node.Value = deepestNode.Value;
                    DeleteDeepestNode(deepestNode);
                    return;
                }
                else
                {
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
            throw new Exception("Node not found");
        }


        //Delete tree
        public void DeleteTree()
        {
            Root = null;
        }

        //Get deepest node
        TreeNode<T> GetDeepestNode()
        {
            if (Root == null)
            {
                throw new Exception("The tree is not initialized or does not contain any nodes");
            }
            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            TreeNode<T> deepestNode = null;
            while (queue.Count != 0)
            {
                deepestNode = queue.Dequeue();
                if (deepestNode.Left != null)
                    queue.Enqueue(deepestNode.Left);
                if (deepestNode.Right != null)
                    queue.Enqueue(deepestNode.Right);
            }

            return deepestNode;
        }

        //Delete deepest node
        void DeleteDeepestNode(TreeNode<T> deepestNode)
        {
            if (Root == null)
            {
                throw new Exception("The tree is not initialized or does not contain any nodes");
            }

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node.Left != null && node.Left == deepestNode)
                {
                    node.Left = null;
                    return;
                }
                else if (node.Right != null && node.Right == deepestNode)
                {
                    node.Right = null;
                    return;
                }
                else
                {
                    queue.Enqueue(node.Right);
                    queue.Enqueue(node.Left);
                }
            }
        }
    }
}
