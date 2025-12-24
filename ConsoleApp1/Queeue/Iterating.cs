using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Queeue
{
    internal class Iterating
    {
        public void iterate(Queue q)

        {
            Console.WriteLine(q.Peek());

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
