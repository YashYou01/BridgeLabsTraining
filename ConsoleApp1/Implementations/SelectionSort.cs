using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    internal class SelectionSort
    {
        public void ss(int [] array) {
            
            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("SelectionSortingDone");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
