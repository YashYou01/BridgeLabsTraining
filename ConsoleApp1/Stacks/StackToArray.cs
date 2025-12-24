using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Stacks
{
    internal class StackToArray
    {
        public void convert(Stack st)
        {
            int[] array = new int[st.Count];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = (int)st.Pop();
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
