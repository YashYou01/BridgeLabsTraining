using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;



namespace ConsoleApp1.HastTable
{
    internal class Iter
    {
        public void iter(Hashtable ht)
        {
            foreach (object keys in ht.Keys)
            {
                Console.WriteLine(keys);
            }
        }
    }
}
