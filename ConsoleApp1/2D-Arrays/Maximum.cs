using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2D_Arrays
{
    internal class Maximum
    {
        public void max(int[,] array)
        {
            int max = int.MinValue;
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max= array[i, j];
                    }
                }

            }
            Console.WriteLine(max);
        }
    }
}
