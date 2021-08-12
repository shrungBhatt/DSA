using DSA.LinkedList.SLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinkedList.CSLL
{
    public class CircularSingleLinkedList<T>
    {
        public SingleNode<T> Head { get; set; }
        public SingleNode<T> Tail { get; set; }
        public int Size { get; set; }
        public bool circularSingleLinkedListsExists { get => Head != null; }


        public void CreateCircularSingleLinkedList(T value)
        {
            var node = new SingleNode<T> { Value = value };

            //Set this new node as head and as the next node of the head
            node.Next = node;
            Head = node;

            //Set this new node as tail and as the next node of the tail
            Tail = node;
            Size = 1;
        }

        public SingleNode<T> AddFirst(T value)
        {
            if (!circularSingleLinkedListsExists)
            {
                return null;
            }
            //Create the new node
            var newNode = new SingleNode<T> { Value = value };

            //Make the new node next reference as the head
            newNode.Next = Head;

            //Make the new node the head node
            Head = newNode;

            //Make the next node of Tail the new node
            Tail.Next = newNode;

            Size += 1;

            return newNode;
        }

        public SingleNode<T> AddLast(T value)
        {
            if (!circularSingleLinkedListsExists)
            {
                return null;
            }

            //Create the new node
            var newNode = new SingleNode<T> { Value = value };

            //Assign the next of new node as next node of the tail
            newNode.Next = Tail.Next;

            //Set the next reference of tail as the reference of new node
            Tail.Next = newNode;

            //Set the new node as the latest tail
            Tail = newNode;

            //Increment the size of the list by 1
            Size += 1;

            return newNode;
        }


        public SingleNode<T> AddAfter(SingleNode<T> afterNode, T value)
        {
            if (!circularSingleLinkedListsExists)
            {
                return null;
            }

            if (Head.GetHashCode() == afterNode.GetHashCode())
            {
                return AddFirst(value);
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

        public SingleNode<T> SearchNode(T value)
        {
            if (!circularSingleLinkedListsExists)
            {
                return null;
            }

            SingleNode<T> tempNode = Head;
            while (true)
            {
                if (EqualityComparer<T>.Default.Equals(tempNode.Value, value))
                {
                    return tempNode;
                }
                tempNode = tempNode.Next;

                if(tempNode.GetHashCode() == Head.GetHashCode())
                {
                    return null;
                }
            }
        }

        public void DeleteNode(T value)
        {
            if (!circularSingleLinkedListsExists)
            {
                return;
            }

            var tempNode = Head;
            SingleNode<T> cachedNode = null;
            for (int i = 0; i < Size; i++)
            {
                if (EqualityComparer<T>.Default.Equals(tempNode.Value, value))
                {
                    if (tempNode.GetHashCode() == Head.GetHashCode())
                    {
                        Head = tempNode.Next;
                        Tail.Next = Head;
                        Size -= 1;
                        break;
                    }
                    else if (tempNode.GetHashCode() == Tail.GetHashCode())
                    {
                        Tail = cachedNode;
                        Tail.Next = Head;
                        Size -= 1;
                        break;

                    }
                    else
                    {
                        cachedNode.Next = tempNode.Next;
                        Size -= 1;
                        break;
                    }
                }
                cachedNode = tempNode;
                tempNode = tempNode.Next;
            }
        }

        public void TraverseList()
        {
            var node = Head;
            while (true)
            {
                Console.Write($"{node.Value}");
                if (node.GetHashCode() == Tail.GetHashCode())
                    break;
                else
                    Console.Write(" -> ");
                node = node.Next;
            }
        }

    }
}
