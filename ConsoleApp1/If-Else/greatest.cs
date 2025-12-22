using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class greatest
    {
        public void great(int a,int b,int c)
        {
            if(a>b && a > c)
            {
                Console.WriteLine(a+" is the maximum");
            }
            else if(b>a && b > c)
            {
                Console.WriteLine(b+" is the maximum");
            }
            else if(c>a && c > b)
            {
                Console.WriteLine(c+" is the maximum");
            }
        }
    }
}
