using ConsoleApp1._2D_Arrays;
using ConsoleApp1.arrayList;
using ConsoleApp1.Arrays;
//using ConsoleApp1.If_Else; 
using System.Collections;

using ConsoleApp1.Strings;
using ConsoleApp1.Stacks;
using ConsoleApp1.Queeue;
using ConsoleApp1.HastTable;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iter print = new Iter();
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter no of entries");
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter key: ");
                string key = Console.ReadLine();

                Console.Write("Enter value: ");
                string value = Console.ReadLine();
                    
                ht.Add(key, value);
            }

            print.iter(ht);


        }

    }
}
