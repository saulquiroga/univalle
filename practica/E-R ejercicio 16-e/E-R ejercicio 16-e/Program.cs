﻿using System;

namespace E_R_ejercicio_16_e
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, a, x, r, y;
            char A, B;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INTRODUZCA UN NUMERO PAR:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                N = Convert.ToInt32(Console.ReadLine());
            } while (N % 2 == 1||N<2);
            a = N / 2 + 1;
            y = 1;
            x = 1;
            for (i = 1; i <= N / 2; i = i + 1)
            {
                for (j = 1; j <= N / 2 - y; j = j + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
                for (r = 1; r <= x + 1; r = r + 1)
                {
                    Console.Write("*");
                }
                a = a + 1;
                x = x + 2;
                y++;
                Console.WriteLine();
            }
            y = 0;
            x = 1;
            for (i = 3; i <= a; i++)
            {
                for (j = 1; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (r = y; r < N; r++)
                {
                    Console.Write("*");
                }
                a = a - 1;
                x++; ;
                y = y + 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
