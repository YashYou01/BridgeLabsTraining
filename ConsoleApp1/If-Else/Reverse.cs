using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class Reverse
    {
        public int rever(int n)
        {
            int num=0;
            while (n > 0)
            {
                int rem = n % 10;
                num = num * 10 + rem;
                n = n / 10;
            }
            return num;
        }
    }
}
