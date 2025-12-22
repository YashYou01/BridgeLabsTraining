    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ConsoleApp1.Arrays
    {
        internal class MissingNumber
        {
            public void MN(int []array)
            {
                int sum = 0;
                int n = array.Length+1;
                int sum2 = (n * (n + 1)) / 2;
            Console.WriteLine(sum2);
            for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
            Console.WriteLine(sum);
            int ans = sum2 - sum;
                Console.WriteLine( ans );
            }
        }
    }
