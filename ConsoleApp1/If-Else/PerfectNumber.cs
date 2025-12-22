using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class PerfectNumber
    {
        public void pn(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("It is a perfect number");

            }
            else
            {
                Console.WriteLine("It is not a perfect number");
            }
        }
    }
}
