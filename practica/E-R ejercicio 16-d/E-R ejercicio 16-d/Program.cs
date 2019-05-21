using System;

namespace E_R_ejercicio_16_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, a, x, r;
            char A, B;
            do
            {
                Console.Write("Introduzca un numero impar:");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N % 2 == 0||N<2);
            A = '*';
            B = ' ';
            a = N / 2 + 1;
            x = 1;
            for (i = 1; i <= N / 2 + 1; i = i + 1)
            {
                for (j = 1; j <= N - a; j = j + 1)
                {
                    Console.Write("" + B);
                }
                for (r = 1; r <= x; r = r + 1)
                {
                    Console.Write("" + A);
                }
                for (j = 1; j <= N - a; j = j + 1)
                {
                    Console.Write("" + B);
                }
                a = a + 1;
                x = x + 2;
                Console.WriteLine();
            }
            for (i = 3; i <= a - 1; i = i + 1)
            {
                for (j = 1; j <= N - N + 1; j = j + 1)
                {
                    Console.Write("" + B);
                }
                for (j = 1; j <= N - a + 1; j = j + 1)
                {
                    Console.Write("" + B);
                }
                for (r = 5; r <= x; r = r + 1)
                {
                    Console.Write("" + A);
                }
                for (j = 1; j <= N - a + 1; j = j + 1)
                {
                    Console.Write("" + B);
                }
                for (j = 1; j <= N - N + 1; j = j + 1)
                {
                    Console.Write("" + B);
                }
                a = a - 1;
                x = x - 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
