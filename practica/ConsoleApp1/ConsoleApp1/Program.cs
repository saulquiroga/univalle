using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            Console.Write("introduzca un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            x = 1;
            int[,] che = new int[n, n];
            for (int i=0;i<n;i++)
            {
                for (int j = 0; j  < n; j++)
                {
                    che[i, j] = x;
                    x++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j=j+2)
                {
                    Console.Write("\t"+che[i,j]);
                    
                }
                Console.WriteLine();
            }
            Console.Write(che.Length);
            Console.ReadKey();
        }
    }
}
