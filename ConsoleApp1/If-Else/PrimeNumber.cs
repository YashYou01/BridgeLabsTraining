using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class PrimeNumber
    {
        public void prime(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Not a prime number");
            }
            Boolean flag = true;
            for(int i = 2; i <n; i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Not a prime Number");
            }
            else
            {
                Console.WriteLine("prime number");
            }
        }
    }
}
