using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.arrayList
{
    internal class InsertAtK
    {
        public void insert(ArrayList al,int k)
        {
            Console.WriteLine("Add k: ");

            int n = int.Parse(Console.ReadLine());

            al.Insert(k, n);
            Console.WriteLine("Updated List: ");

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

        }
        public void remove(ArrayList al)
        {
            Console.WriteLine("Add Index of element to b removed: ");

            int n = int.Parse(Console.ReadLine());

            al.RemoveAt(n);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}
