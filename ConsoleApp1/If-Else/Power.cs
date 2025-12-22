using System;

namespace ConsoleApp1.If_Else
{
    internal class Power
    {
        public void Pow( int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * 2;
                Console.WriteLine(result);
            }
        }
    }
}
