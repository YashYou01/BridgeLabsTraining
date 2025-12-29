using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    internal class LinearSearch
    {
        public void ls(int[] array, int k)
        {
            bool flag = false;
            for(int i = 0; i < k; i++)
            {
                if (array[i] == k)
                {
                    Console.WriteLine("Found Using linear search");
                    flag = true;
                    break;
                }
                
            }
            if (flag == false)
            {
                Console.WriteLine("Element not found: ");
            }

        }
    }
}
