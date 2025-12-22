using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.If_Else
{
    internal class Vowel
    {
        public void vowel(char s)
        {
            if(s == 'a' || s=='e' || s == 'i' || s == 'o' || s == 'u')
            {
                Console.WriteLine("Yes it is a vowel");
            }
            else
            {
                Console.WriteLine("No it isnt");
            }
        }
    }
}
