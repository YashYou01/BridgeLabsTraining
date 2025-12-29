using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
     class StackImple
    {
        int size;
        int[] array;
        int top;

        public StackImple(int size)
        {
            this.size = size;
            array = new int[size];
            top = -1;
        }

        public void push(int x)
        {
            if (top<size-1)
            {
                top++;
                array[top] = x;
            }
            else
            {
                Console.WriteLine("Stack overflow");
            }
        }
        public void pop()
        {
            if (top >= 0)
            {
                top--;
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
        }
        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack elements (top to bottom):");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
