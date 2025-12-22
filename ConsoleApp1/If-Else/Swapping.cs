using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class Swapping
    {
        public void swap(int a,int b) {
            int TEMP;
            TEMP = a;
            a = b;
            b=TEMP;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
