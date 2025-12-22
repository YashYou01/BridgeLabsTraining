using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class Reverse
    {
        public void rev(String str)
        {
            char[] array = str.ToCharArray();
            int x = 0;
            int y = array.Length - 1;

            while (y > x)
            {
                char temp=array[x];
                array[x] = array[y];

                array[y] = temp;    
                x++;
                y--;
            }
            string result = string.Concat(array);
            Console.WriteLine(result);

        }
    }
}
