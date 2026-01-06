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
using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fp= @"C:\Users\hp\OneDrive\Desktop\BridgeLabsTraining\ConsoleApp1\File Handling\FirstFile.txt";

            using (FileStream fs = new FileStream(fp, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    StringBuilder sb = new StringBuilder();

                    while (!sw.EndOfStream)
                    {
                        sb.AppendLine(sw.ReadLine());
                        
                    } 
                    Console.WriteLine(sb.ToString());

                }
            }
            
        }

    }
}

