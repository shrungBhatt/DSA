using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    internal class QuickSort
    {
        internal void Sort(int[] array, int start, int end)
        {
            if(end > start)
            {
                int partition = Partition(array, start, end);
                Sort(array, start, partition - 1);
                Sort(array, partition + 1, end);
            }
        }

        int Partition(int[] array, int p, int q)
        {
            int pivot = q;
            int i = p - 1;

            for (int j = p; p <= q; p++)
            {
                if(array[j] <= array[pivot])
                {
                    i++;
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            return p;
        }
    }
}
