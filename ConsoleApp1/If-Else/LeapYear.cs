using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class LeapYear
    {
        public void leap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Yes it is a leap year");
            }
            else
            {
                Console.WriteLine("No it isnt a leap year");
            }
        }
    }
}
