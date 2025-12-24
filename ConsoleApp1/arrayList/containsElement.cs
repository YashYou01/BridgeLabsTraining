using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.arrayList
{
    internal class containsElement
    {
        public void contains(ArrayList al)
        {
            Console.WriteLine("Enter Element to find: ");
            int n = int.Parse(Console.ReadLine());



            if (al.Contains(n))
            {
                int index = al.IndexOf(n);
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element Not found");
            }
        }

    }
}
