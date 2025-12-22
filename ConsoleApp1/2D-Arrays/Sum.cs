using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2D_Arrays
{
    internal class Sum
    {
        public void sum(int[,] array)
        {
            int sum = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
