using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    internal class HeapByArray
    {
        int[] heap;
        int heapSize;
        
        //Creating the heap
        internal HeapByArray(int size)
        {
            heap = new int[size+1];
            heapSize = 0;
        }

        internal void DeleteHeap()
        {
            heap = null;
            heapSize = 0;
        }

        internal int Peek()
        {
            if(heapSize < 1)
            {
                return -1;
            }
            else
            {
                return heap[1];
            }
        }


        internal void Insert(int value)
        {
            heap[heapSize + 1] = value;
            heapSize++;
            HeapifyBottomToTop(heapSize);
        }

        internal int ExtractHead()
        {
            if(heapSize > 0)
            {
                var value = heap[1];
                heap[1] = heap[heapSize];
                heapSize--;
                HeapifyTopToBottom(1);
                return value;
            }
            else
            {
                return -1;
            }
            
        }

        internal void HeapifyBottomToTop(int index)
        {
            int parent = index / 2;

            if(index <= 1)//Only head is present
            {
                return;
            }

            if(heap[index] < heap[parent])
            {//Swap values
                var temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;
            }
            //Continue till we reach the top
            HeapifyBottomToTop(parent);
        }

        internal void HeapifyTopToBottom(int index)
        {
            var left = 2 * index;
            var right = (2 * index) + 1;
            int smallest;

            if (heapSize < left) { return; }//Only head is present
            else if (heapSize == left)
            {
                if (heap[left] < heap[index])
                {
                    var temp = heap[index];
                    heap[index] = heap[left];
                    heap[left] = temp;
                }
                return;
            }
            else
            {
                if (heap[left] < heap[right])
                {
                    smallest = left;
                }
                else
                {
                    smallest = right;
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
}
