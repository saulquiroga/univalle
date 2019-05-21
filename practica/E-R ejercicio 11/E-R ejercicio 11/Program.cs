using System;

namespace E_R_ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, t, x, c;
            do
            {
                Console.Write("introduzca un numero para la serie: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            t = 2;
            x = 3;
            c = 0;
            for (c = 0; c < n; c++)
            {
                for (i = 1; i <= t && c < n; i++)
                {
                    Console.Write(i);
                    c++;
                }
                if (c < n)
                {
                    Console.Write(x);
                }

                t = t + 1;
                x = x + 2;
            }
            Console.ReadKey();
        }
    }
}
