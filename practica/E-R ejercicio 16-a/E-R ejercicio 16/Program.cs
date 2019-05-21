using System;

namespace E_R_ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, i, a, r, x;
            do
            {
                Console.Write("introduzca un numero impar: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n % 2 == 0||n<=2);
            a = 0;
            x = 1;
            for (i = x; i <= n ; i++)
            {
                for (r = 1; r <= n-a; r++)
                {
                    Console.Write("*");
                }
                a++;
                x++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
