using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementations
{
    class  LinklistNode
    {
        public int data;
        public LinklistNode next;

        public LinklistNode(int x)
        {
            data = x;
            next = null;

        }

    }
    class linkedlixt
    {
        LinklistNode head = null;

        public linkedlixt()
        {
            head = null;
        }

        public void add(int data)
        {
            LinklistNode node = new LinklistNode(data);
            node.next = head;
            head = node;
        }
        public void print()
        {
            LinklistNode run = head;
            while (run != null)
            {
                Console.WriteLine(run.data);
                run = run.next;
            }
        }
    }
}
