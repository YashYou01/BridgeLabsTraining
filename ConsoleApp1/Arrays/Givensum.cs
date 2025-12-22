using System;

namespace ConsoleApp1.Arrays
{
    internal class Givensum
    {
        public int[,] Sum(int[] array, int target)
        {
            int count = 0;

            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        count++;
                    }
                }
            }

            
            int[,] result = new int[count, 2];

            int index = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        result[index, 0] = array[i];
                        result[index, 1] = array[j];
                        index++;
                    }
                }
            }

            return result;
        }
    }
}
