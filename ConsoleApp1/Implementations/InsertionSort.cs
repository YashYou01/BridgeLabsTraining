using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    internal class InsertionSort
    {
        public void isort(int[] array)
        {
            for(int i=0;i<array.Length; i++)
            {
                int temp=array[i];
                int j = i - 1;
                while(j >= 0 )
                {
                    if (array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    else
                    {
                        break;
                    }

                }
                array[j + 1] = temp;
            }
            Console.WriteLine("InsertionSortingDone");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
