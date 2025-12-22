using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    internal class Duplicates
    {
        public void dup(int[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                        break;
                    }
                }
            }
        }
    }
}
