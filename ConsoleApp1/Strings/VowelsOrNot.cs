using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Strings
{
    internal class VowelsOrNot
    {
        public void von(Char str)
        {
            

          
                if(str=='a'|| str == 'e' || str == 'i' || str == 'o' || str == 'u')
                {
                Console.WriteLine("It is a vowel");

                
            }
            else
            {
                Console.WriteLine("Not a vowel");
            }
            
        }
    }
}
