﻿using System;

namespace E_R_ejercicio_16_f
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, a, x, r;
            do
            {
                Console.Write("Introduzca un numero impar:");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N % 2 == 0||N<2);
            a = 0;
            x = 0;
            for (i = 1; i <=N-a; i++)
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
            a = 0;
            x = 1;
            for (i = 1; i <= N - a; i++)
            {           
                for (j = 1; j <= N/2-a; j++)
                {
                    Console.Write(" ");
                }
                for (r = 1; r <= x; r++)
                {
                    Console.Write("*");
                }
                a = a + 1 ;
                x=x+2 ;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
