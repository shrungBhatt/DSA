using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    internal class MergeSort
    {
        //30, 20, 40, 10, 80, 50, 15
        internal void Sort(int[] array, int left, int right)//left = 0, right = 1
        {
            if(right > left)//false
            {
                int middle = (left + right) / 2;//middle = 0
                Sort(array, left, middle);// 
                Sort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        internal void Merge(int[] array, int left, int middle, int right)
        {
            int[] leftTempArray = new int[middle - left + 2];
            int[] rightTempArray = new int[right - middle + 1];


            for(int i = 0; i < middle - left; i++)
            {
                leftTempArray[i] = array[left+i];
            }
            for (int i = 0; i < right - middle; i++)
            {
                rightTempArray[i] = array[middle + 1 + i];
            }

            leftTempArray[middle - left + 1] = int.MaxValue;
            rightTempArray[right - middle] = int.MinValue;
            int x = 0; int y = 0;
            for (int k = left; k <= right; k++)
            {
                if (leftTempArray[x] < rightTempArray[y])
                {
                    array[k] = leftTempArray[x];
                    x++;
                }
                else
                {
                    array[k] = rightTempArray[y];
                    y++;
                }
            }
        }
    }
}
