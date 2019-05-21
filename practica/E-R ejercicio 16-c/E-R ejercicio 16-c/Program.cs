using System;

namespace E_R_ejercicio_16_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, i, a, r, x;
            do
            {
                Console.Write("introduzca un numero : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<=2);
            a = 0;
            x = 1;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - a; j++)
                {
                    Console.Write(" ");
                }
                for (r = 1; r <= x; r++)
                {
                    Console.Write("*");
                }
                a = a + 1;
                x = x + 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
