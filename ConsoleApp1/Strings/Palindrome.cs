using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class Palindrome
    {
        public void pali(String str)
        {
            char[] array= str.ToCharArray();
            int x = 0;
            int y = array.Length - 1;
            Boolean flag = true;
            while (x < y)
            {
                if (array[x] != array[y])
                {
                    flag = false;
                    
                    break;
                }
                x++;
                y--;
            }
            if(flag==true)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");

            }
        }
    }
}
