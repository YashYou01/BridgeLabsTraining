using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Queeue
{
    internal class QtoArray
    {
        public void convertt(Queue q)
        {
            int[] array = new int[q.Count];
            for(int i = 0; i < q.Count; i++)
            {
                array[i]=(int)q.Dequeue();
            }
            for (int i = 0; i < q.Count; i++)
            {
                Console.Write(array[i]);
            }

        }

    }
}
