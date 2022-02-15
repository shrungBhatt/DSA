using DSA.LinkedList.SLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.ArrayStrings
{
    internal class MergeKSortedLists
    {

        List<int> heap = new List<int>() { int.MinValue };

        public SingleNode<int> MergeKLists(SingleNode<int>[] lists)
        {
            var head = new SingleNode<int>();

            if (lists != null)
            {
                foreach (var list in lists)
                {
                    var temp = list;
                    while (temp != null)
                    {
                        InsertInHeap(temp.Value);
                        temp = temp.Next;
                    }
                }

                var tempNode = head;
                while (heap.Count > 1)
                {
                    tempNode.Next = new SingleNode<int>() { Value = ExtractHead() };
                    tempNode = tempNode.Next;
                }
            }

            return head.Next;
        }


        public void InsertInHeap(int val)
        {
            heap.Add(val);
            HeapifyBottomToTop(heap.Count - 1);
        }

        public void HeapifyBottomToTop(int index)
        {
            int parent = index / 2;

            if (index <= 1)
            {
                return;
            }

            if (heap[parent] > heap[index])
            {
                var temp = heap[parent];
                heap[parent] = heap[index];
                heap[index] = temp;
            }

            HeapifyBottomToTop(parent);
        }

        public int ExtractHead()
        {
            if (heap.Count > 1)
            {
                var temp = heap[1];
                heap[1] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                HeapifyTopToBottom(1);

                return temp;
            }
            return -1;
        }

        public void HeapifyTopToBottom(int index)
        {
            int left = index * 2;
            int right = (index * 2) + 1;
            int smallest;

            if (heap.Count - 1 < left) return;//Only head is present
            else if (heap.Count - 1 == left)
            {
                if (heap[index] > heap[left])
                {
                    var temp = heap[index];
                    heap[index] = heap[left];
                    heap[left] = temp;
                }
                return;
            }
            else
            {
                Console.WriteLine($"Count:{heap.Count}, left:{left}, right:{right}");
                if (heap[left] > heap[right])
                {
                    smallest = right;
                }
                else
                {
                    smallest = left;
                }

                if (heap[index] > heap[smallest])
                {
                    var temp = heap[index];
                    heap[index] = heap[smallest];
                    heap[smallest] = temp;
                }
            }
            HeapifyTopToBottom(smallest);
        }


    }

    public class Solution
    {



    }
}
