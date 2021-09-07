using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinkedList.DLL
{
    public class DoubleLinkedList<T>
    {
        public DoubleNode<T> Head { get; set; }
        public DoubleNode<T> Tail { get; set; }
        public int Size { get; set; }
        public bool DLLExists { get => Head != null; }


        public void CreateDoubleLinkedList(T value)
        {
            var node = new DoubleNode<T> { Value = value };
            Head = node;
            Tail = node;
            Size = 1;
        }

        public DoubleNode<T> AddFirst(T value)
        {
            if (!DLLExists)
            {
                return null;
            }

            var node = new DoubleNode<T> { Value = value };
            node.Next = Head;
            node.Previous = null;
            Head.Next = node;
            Head = node;

            return node;
        }

        public DoubleNode<T> AddLast(T value)
        {
            if (!DLLExists)
            {
                return null;
            }

            var node = new DoubleNode<T> { Value = value };
            node.Next = null;
            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;

            Size += 1;

            return node;
        }

        public DoubleNode<T> AddBefore(DoubleNode<T> beforeNode, T value)
        {
            return null;
        }

        public DoubleNode<T> AddAfter(DoubleNode<T> afterNode, T value)
        {
            return null;
        }

        public void DeleteNode(T value)
        {

        }

        public DoubleNode<T> SearchNode(T value)
        {
            return null;
        }

        public void TraverseDLL()
        {

        }

        public void ReverseTraverseDLL()
        {

        }

    }
}
