using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    internal class MergeSort
    {
        public void ms(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int mid = (start + end) / 2;

            ms(array, start, mid);
            ms(array, mid + 1, end);

            merge(array, start, end);
        }

        public void merge(int[] array, int start, int end)
        {
            int mid = (start + end) / 2;
            int len1 = mid - start + 1;
            int len2 = end - mid;

            int[] arrayleft = new int[len1];
            int[] arrayright = new int[len2];

            for (int i = 0; i < len1; i++)
                arrayleft[i] = array[start + i];

            for (int i = 0; i < len2; i++)
                arrayright[i] = array[mid + 1 + i];

            int index1 = 0, index2 = 0, k = start;

            while (index1 < len1 && index2 < len2)
            {
                if (arrayleft[index1] <= arrayright[index2])
                    array[k++] = arrayleft[index1++];
                else
                    array[k++] = arrayright[index2++];
            }

            while (index1 < len1)
                array[k++] = arrayleft[index1++];

            while (index2 < len2)
                array[k++] = arrayright[index2++];
        }

        public void PrintArray(int[] array)
        {
            Console.WriteLine("MergeSortingDone");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
