using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinkedList.SLL
{
    public class SingleLinkedList<T>
    {
        public SingleNode<T> Head { get; set; }
        public SingleNode<T> Tail { get; set; }
        public int Size { get; set; }
        bool linkedListExists { get => Head != null; }

        public SingleNode<T> CreateSingleLinkedList(T value)
        {
            //Create empty single node
            var node = new SingleNode<T>();

            //Assign the value to the node
            node.Value = value;

            //Set the Head and Tail as current node
            Head = node;
            Head.Next = node;

            Tail = node;
            Tail.Next = node;

            //Set the size of the list to 1
            Size = 1;

            return node;
        }

        public SingleNode<T> AddFirst(T value)
        {
            //Return null if no linked list exists
            if (!linkedListExists)
            {
                return null;
            }

            //Create the new node and assign the value
            var newNode = new SingleNode<T> { Value = value };

            //Assign the next of head to the next of new node
            newNode.Next = Head;

            //Assign the next of head as new node
            Head = newNode;

            //Increment the size by 1
            Size += 1;

            //Return the newly created node
            return newNode;
        }

        public SingleNode<T> AddLast(T value)
        {
            if (!linkedListExists)
            {
                return null;
            }

            var newNode = new SingleNode<T> { Value = value };
            newNode.Next = null;
            Tail.Next = newNode;
            Tail = newNode;
            Size += 1;
            return newNode;
        }

        public SingleNode<T> AddAfter(SingleNode<T> afterNode, T value)
        {
            if (!linkedListExists)
            {
                return null;
            }

            if (Head.GetHashCode() == afterNode.GetHashCode())
            {
                return AddFirst(value); ;
            }

            if (Tail.GetHashCode() == afterNode.GetHashCode())
            {
                return AddLast(value);
            }


            var newNode = new SingleNode<T> { Value = value };
            bool found = false;
            SingleNode<T> tempNode = null;
            while (!found)
            {
                if (tempNode == null)
                {
                    tempNode = Head.Next;
                }
                else
                {
                    tempNode = tempNode.Next;
                }

                if (afterNode.GetHashCode() == tempNode.GetHashCode())
                {
                    found = true;
                }
            }

            newNode.Next = tempNode.Next;
            tempNode.Next = newNode;

            Size += 1;
            return newNode;
        }

        public void TraverseLinkedList()
        {
            if (!linkedListExists)
            {
                return;
            }

            SingleNode<T> tempNode = Head;
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"{tempNode.Value}");
                tempNode = tempNode.Next;
                if(i < Size - 1)
                {
                    Console.Write(" -> ");
                }
            }

            Console.WriteLine($"\nSize of the linked list is: {Size}");
        }

        public SingleNode<T> SearchNode(T value)
        {
            SingleNode<T> tempNode = Head;
            for(int i = 0; i < Size; i++)
            {
                if (EqualityComparer<T>.Default.Equals(tempNode.Value, value))
                {
                    return tempNode;
                }
                tempNode = tempNode.Next;
            }
            return null;
        } 
    }
}
