using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class Anagram

    {
        public void ana(String str,String dtr)
        {
            
                char [] array1 = str.ToCharArray();
                char [] array2 = dtr.ToCharArray();
            int x = 0;
            int y = array1.Length;
            Boolean flag = true;
            if (str.Length != dtr.Length)
            {
               flag=false;
            }

            while (x < y)
            {
                if (!array2.Contains(array1[x]) && !array1.Contains(array2[x]))
                {
                    flag = false;
                    break;
                }
                x++;
            }
            if (flag == true){
                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not anagrams");
            }

            
        }
    }
}
