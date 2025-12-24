using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.Stacks
{
    internal class Iterate
    {
        public void print(Stack st)
        {
           while(st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
