using ConsoleApp1._2D_Arrays;
using ConsoleApp1.arrayList;
using ConsoleApp1.Arrays;
using ConsoleApp1.HastTable;
using ConsoleApp1.Implementations;
using ConsoleApp1.LinQ;
using ConsoleApp1.Queeue;
using ConsoleApp1.Stacks;
using ConsoleApp1.Strings;
//using ConsoleApp1.If_Else; 
using System.Collections;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueImpli q=new QueueImpli(6);
            q.enqueue(10);
            q.enqueue(9);
            q.enqueue(8);
            q.enqueue(7);
            q.enqueue(6);
            q.enqueue(5);


            q.print();


        }

    }
}