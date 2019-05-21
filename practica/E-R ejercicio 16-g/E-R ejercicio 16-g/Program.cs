using System;

namespace E_R_ejercicio_16_g
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, a, x, r;
            do
            {
                Console.Write("Introduzca un numero par:");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N % 2 ==1||N<4);
            a = 0;
            x = 0;
            for (i = 1; i <= N/2 ; i++)
            {
                for (r = 0; r < a; r++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= N - x; j++)
                {
                    Console.Write("*");
                }
                a++;
                x = x + 2;
                Console.WriteLine();
            }
            a = 2;
            x = 1;
            for (i = 1; i <= N/2; i++)
            {
                for (j = 1; j <= N/2-x; j++)
                {
                    Console.Write(" ");
                }
                for (r = 1; r <= a; r++)
                {
                    Console.Write("*");
                }
                a = a + 2;
                x++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
