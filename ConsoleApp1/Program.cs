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
            //LonestSS str = new LonestSS();
            //Console.WriteLine("Enter a String: ");
            //string s=Console.ReadLine();

            //Console.WriteLine(str.lenOfLongSS(s));

            var ll = new LinkedList();
            ll.push(5);
            ll.push(6);
            ll.push(7);
            ll.push(8);

            ll.print(); 
            Console.WriteLine(ll.pop());


        }

    }
}

