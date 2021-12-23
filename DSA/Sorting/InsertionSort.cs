using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    internal class InsertionSort
    {
        internal void Sort(int[] array)
        {
            //30, 10, 50, 20, 60, 40
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];//currentNumber = 10
                int j = i; // j = 1

                while(j > 0 && array[j - 1] > currentNumber)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = currentNumber;
            }
        }
    }
}
