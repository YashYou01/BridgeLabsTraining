using ConsoleApp1._2D_Arrays;
using ConsoleApp1.Arrays;
//using ConsoleApp1.If_Else;
using ConsoleApp1.Strings;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumRC s = new SumRC();
            int n =int.Parse( Console.ReadLine());

            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    array[i,j]=int.Parse(Console.ReadLine());
                }
            }
            s.sumr(array);
            s.sumc(array);

        }

    }
}
