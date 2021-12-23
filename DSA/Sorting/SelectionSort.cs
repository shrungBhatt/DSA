using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    internal class SelectionSort
    {
        internal void Sort(int[] array)
        {
            //30, 10, 50, 20, 60, 40
            for(int i = 0; i < array.Length; i++)//30
            {
                int iMin = i;//0
                for(int j = i + 1; j < array.Length; j++)//j = 4
                {
                    if(array[j] < array[iMin])//20 < 10
                    {
                        iMin = j;//iMin = 1
                    }
                }

                if(iMin != i)//iMin = 1 i = 0
                {
                    var temp = array[iMin];
                    array[iMin] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
