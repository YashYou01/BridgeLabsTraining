using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class CountVandC
    {
        public void count(String str)
        {
            int countv = 0;
            int countc = 0;
            char[] array = str.ToCharArray();

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'a'|| array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u')
                {
                    countv++;

                }
                else
                {
                    countc++;
                }
            }
            Console.WriteLine("total vowels are :" + countv + " and total consonents are :" + countc);
        }
    }
}
