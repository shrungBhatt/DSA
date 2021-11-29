using DSA.Tree.BinaryTree;
using DSA.Tree.BinaryTree.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Tree
{
    public class BinarySearchTree : BinaryTreeByLinkedList<int>
    {

        public BinarySearchTree()
        {
            Root = null;
        }

        //Create Binary search tree
        public TreeNode<int> CreateBST(int value)
        {
            Root = new TreeNode<int>() { Value = value };
            return Root;
        }

        //Search Binary search tree
        public TreeNode<int> SearchBST(TreeNode<int> node, int value)
        {
            if (node == null)
            {
                return null;
            }
            else if (value == node.Value)
            {
                return node;
            }
            else if (value < node.Value)
            {
                return SearchBST(node.Left, value);
            }
            else 
            {
                return SearchBST(node.Right, value);
            }
        }

        public new void InsertNode(int value)
        {
            InsertNode(Root, value);
        }


        //Inserting a node in Binary search tree
        public TreeNode<int> InsertNode(TreeNode<int> node, int value)
        {
            if (node == null)
            {
                return new TreeNode<int> { Value = value };
            }
            else if (value < node.Value)
            {
                node.Left = InsertNode(node.Left, value);
            }
            else
            {
                node.Right = InsertNode(node.Right, value);
            }

            return node;
        }

        public new void DeleteNode(int value)
        {
            DeleteNode(Root, value);
        }

        //Deleting a node in Binary search tree
        public TreeNode<int> DeleteNode(TreeNode<int> node, int value)
        {
            if (node == null)
            {
                return null;
            }
            if (value > node.Value)//Look for node in the right sub-tree
            {
                node.Right = DeleteNode(node.Right, value);
            }
            else if (value < node.Value)//Look for node in the left sub-tree
            {
                node.Left = DeleteNode(node.Left, value);
            }
            else//Current node is the node to be deleted
            {
                if (node.Left != null && node.Right != null)//If the node has both the children
                {
                    var temp = node;
                    var minNodeForRightSubTree = GetMinimumNode(temp.Right);//Find successor from right sub tree
                    node.Value = minNodeForRightSubTree.Value;//Replace the current node value with successors
                    node.Right = DeleteNode(node.Right, temp.Value);//Delete the successor
                }
                else if (node.Left != null)//The node has only left child
                {
                    node = node.Left;
                }
                else if (node.Right != null)//THe node has only right child
                {
                    node = node.Right;
                }
                else//The node is a leaf
                {
                    node = null;
                }
            }
            return node;
        }

        TreeNode<int> GetMinimumNode(TreeNode<int> node)
        {
            if(node.Left == null)
            {
                return node;
            }
            else
            {
                return GetMinimumNode(node.Left);
            }
        }

    }
}
