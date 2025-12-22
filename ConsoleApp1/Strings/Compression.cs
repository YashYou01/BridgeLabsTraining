using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class Compression
    {
        public void compress(String str)
        {
            StringBuilder result = new StringBuilder();
            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1 && str[i] == str[i + 1])
                {
                    count++;
                }
                else
                {
                    result.Append(str[i]);
                    result.Append(count);
                    count = 1;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
