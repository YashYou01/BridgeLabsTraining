using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    internal class Intersection
    {
        public void inter(int[] array1, int[] array2)
        {
            
            int []ans= new int [Math.Min(array1.Length,array2.Length)];
            int x = 0;

            for(int i = 0; i < array1.Length; i++)
            {
                for(int j=0;j<array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        ans[x] = array1[i];
                        x++;
                        break;
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
}
