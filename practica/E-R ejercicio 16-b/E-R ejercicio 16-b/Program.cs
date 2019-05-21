using System;

namespace E_R_ejercicio_16_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, i, a, r, x, c;
            do
            {
                Console.Write("introduzca un numero impar: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n % 2 == 0||n<2);
            a = n;
            x = 1;
            c = 0;
            for (i = x; i <= n; i++)
            {
                for (r = 1; r <= n - a; r++)
                {
                    Console.Write(" ");
                }
                for (r = 1; r <= n - c ; r++)
                {
                    Console.Write("*");
                }
                a--;
                c++;
                x++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
