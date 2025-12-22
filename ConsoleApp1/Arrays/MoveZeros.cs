using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    internal class MoveZeros
    {
        public void MZ(int[] array)
        {
            int count = 0;
            for(int i=0;i<array.Length; i++)
            {
                if (array[i] == 0)
                {
                    count++; 
                }
            }
            int[] ans = new int[array.Length];
            int x = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0){
                    ans[x] = array[i];
                    x++;
                }
            }
            while (count > 0)
            {
                ans[x] = 0;
                x++;
                count--;
            }
            // Print result
            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
}
