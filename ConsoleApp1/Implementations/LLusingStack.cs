using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int x)
        {
            Data = x;
            Next = null;
        }

    }
    class LinkedList
    {
        Stack<Node> st= new Stack<Node> ();
        Node head;

        public void push(int data)
        {
            var node = new Node(data);
            st.Push (node);
            if(head ==null)
                head = node;
            else
            {
                node.Next = head;
                head= node;
            }
        }
        public int pop()
        {
            if (head == null)
            {
                return -1;
            }
            int data = head.Data;
            head = head.Next;
            return data;
        }
        public void print()
        {
            var temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
