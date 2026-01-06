using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    public class EvenOdd
    {
        public string eveodd(int n)
        {
            string str= "";
            if (n % 2 == 0)
            {
                str+="even";
            }
            else
            {
                str += "odd";
            }
            return str;
        } 
    }
}
