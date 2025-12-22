using System;

namespace ConsoleApp1.If_Else
{
    internal class PrimeFactors
    {
        
        public PrimeFactors() { }

        
        public void PF(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (Prime(i) && n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

     
        public bool Prime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
