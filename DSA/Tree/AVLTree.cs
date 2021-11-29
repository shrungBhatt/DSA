using DSA.Tree.BinaryTree;
using DSA.Tree.BinaryTree.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Tree
{
    public class AVLTree : BinaryTreeByLinkedList<int>
    {
        public AVLTree()
        {
            Root = null;
        }

        public TreeNode<int> CreateAVLTree(int value)
        {
            Root = new TreeNode<int> { Value = value, Height = 0 };
            return Root;
        }

        public void InsertNodeAVLTree(TreeNode<int> node, int value)
        {
            if(node == null)
            {
                return;
            }
            else if(node.Value <= value)
            {
                InsertNodeAVLTree(node.Left, value);
            }
            else
            {
                InsertNodeAVLTree(node.Right, value);
            }

            //Check for the balance and perform the traversals
            int balance = CheckBalance(node.Left, node.Right);
            if(balance > 1)
            {
                if(CheckBalance(node.Left.Left, node.Left.Right) > 0)
                {
                    node = RightRotate(node);
                }
                else
                {
                    node.Left = LeftRotate(node.Left);
                    node = RightRotate(node);
                }
            }
            else if(balance < -1)
            {
                if(CheckBalance(node.Right.Right, node.Right.Left) > 0)
                {
                    node = LeftRotate(node);
                }
                else
                {
                    node.Right = RightRotate(node.Right);
                    node = LeftRotate(node);
                }
            }


            if(node.Left != null)
            {
                node.Left.Height = CalculateHeight(node.Left);
            }

            if(node.Right != null)
            {
                node.Right.Height = CalculateHeight(node.Right);
            }

            node.Height = CalculateHeight(node);
        }

        int CheckBalance(TreeNode<int> leftNode, TreeNode<int> rightNode)
        {
            if(leftNode == null && rightNode == null)
            {
                return 0;
            }else if(leftNode == null)
            {
                return -1 * rightNode.Height + 1;
            }
            else if(rightNode == null)
            {
                return leftNode.Height + 1;
            }
            else
            {
                return leftNode.Height - rightNode.Height;
            }
        }

        private TreeNode<int> DeleteNode(TreeNode<int> node, int value)
        {
            if(node == null)
            {
                return null;
            }
            else if(node.Value > value)
            {
                node = DeleteNode(node.Left, value);
            }
            else if(node.Value < value)
            {
                node = DeleteNode(node.Right, value);
            }
            else
            {
                if(node.Left != null && node.Right != null)
                {
                    var temp = node;    
                    var min = GetMinimumNode(temp.Right);
                    node.Value = min.Value;
                    temp.Right = DeleteNode(node.Right, temp.Value);
                }
                else if(node.Left != null)
                {
                    node = node.Left;
                }
                else if(node.Right != null)
                {
                    node = node.Right;
                }
                else
                {
                    node = null;
                }
            }

            //Perform the AVL balancing
            var balance = CheckBalance(node.Left, node.Right);
            if(balance > 1)//Left subtree is imbalanced
            {
                if(CheckBalance(node.Left.Left, node.Left.Right) > 0)
                {
                    node = RightRotate(node);
                }
                else
                {
                    node.Left = LeftRotate(node.Left);
                    node = RightRotate(node);
                }

            }
            else
            {
                if(CheckBalance(node.Right.Left, node.Right.Right) > 0)
                {
                    node = LeftRotate(node);
                }
                else
                {
                    node.Right = RightRotate(node.Right);
                    node = LeftRotate(node);
                }
            }

            if(node.Left != null)
            {
                node.Left.Height = CalculateHeight(node.Left);
            }

            if(node.Right != null)
            {
                node.Right.Height = CalculateHeight(node.Right);
            }

            node.Height = CalculateHeight(node);

            return node;
        }

        TreeNode<int> GetMinimumNode(TreeNode<int> node)
        {
            if(node.Left != null)
            {
                return GetMinimumNode(node.Left);
            }

            return node;
        }

        public TreeNode<int> RightRotate(TreeNode<int> currentNode)
        {
            var newNode = currentNode.Left;
            currentNode.Left = currentNode.Left.Right;
            newNode.Right = currentNode;
            currentNode.Height = CalculateHeight(currentNode);
            newNode.Height = CalculateHeight(newNode);

            return newNode;
        }

        public TreeNode<int> LeftRotate(TreeNode<int> currentNode)
        {
            var newNode = currentNode.Right;
            currentNode.Right = currentNode.Right.Left;
            newNode.Left = currentNode;
            currentNode.Height = CalculateHeight(currentNode);
            newNode.Height = CalculateHeight(newNode);

            return newNode;
        }

        private int CalculateHeight(TreeNode<int> currentNode)
        {
            if(currentNode == null)
            {
                return 0;
            }

            return 1 + Math.Max(currentNode.Left != null ? currentNode.Left.Height : -1, currentNode.Right != null ? currentNode.Right.Height : -1);
        }

    }
}
