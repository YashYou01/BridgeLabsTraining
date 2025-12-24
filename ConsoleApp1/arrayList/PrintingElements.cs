using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace ConsoleApp1.arrayList
{

    internal class PrintingElements
    {
        
      public void print(ArrayList al)
        {
            for(int i=0;i<al.Count  ;i++)
            {
                Console.WriteLine(al[i]);
            }
        }

    }
}
