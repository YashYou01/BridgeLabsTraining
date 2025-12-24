using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.arrayList
{
    internal class SortList
    {
        public void sort(ArrayList al)
        {
            al.Sort();
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}
