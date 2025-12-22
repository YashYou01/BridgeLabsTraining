using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2D_Arrays
{
    internal class SumRC
    {
        public void sumr(int[,] array)

        {
            int Sum = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0;j< array.GetLength(1); j++)
                {
                    Sum = Sum + array[i, j];
                }
                Console.WriteLine(Sum);
                Sum = 0;
            }
        }
        public void sumc(int[,] array)

        {
            for (int j = 0; j < array.GetLength(1); j++)   
            {
                int Sum = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Sum += array[i, j];
                }

                Console.WriteLine(Sum);
            }
        }
    }

    }
}
