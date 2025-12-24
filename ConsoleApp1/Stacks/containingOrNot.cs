using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Stacks
{
    internal class containingOrNot
    {
        public void corn(Stack st)
        {
            Console.WriteLine("Enter element to search: ");
            int n=int.Parse(Console.ReadLine());

            if (st.Contains(n))
            {
                Console.WriteLine("Existing");
            }
            else
            {
                Console.WriteLine("Not Existing");
            }


        }
    }
}
