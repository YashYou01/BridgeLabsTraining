using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    internal class BinarySearch
    {
        
            public void Search(int[] array, int target)
            {
            bool flag = false;
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                int mid = left + (right - left) / 2;


                if (array[mid] == target)
                {
                    Console.WriteLine("Element found using Binary search: ");
                    flag = true;
                    break;
                }
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
                }
            if (flag == false)
            {
                Console.WriteLine("Element not found: ");
            }
                 

            }
        }
    }