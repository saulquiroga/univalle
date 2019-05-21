﻿using System;

namespace M_V_ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, a, b;
            do
            {
                Console.WriteLine("INTRODUZCA UN NUMERO PARA LA MATRIZ:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            int[] tam_fila = new int[n];
            int[] tam_columna = new int[n];
            int[,] c = new int[n, n];
            x = 1;
            a = 0;
            b = 1;
            while (x <= n * n)
            {
                for (int j = a; j <= n - b; j++)
                {
                    c[a, j] = x;
                    x++;
                }
                for (int i = b; i <= n - b; i++)
                {
                    c[i, n - b] = x;
                    x++;
                }
                for (int j = n - 1 - b; j >= a; j--)
                {
                    c[n - b, j] = x;
                    x++;
                }
                for (int i = n - 1 - b; i >= b; i--)
                {
                    c[i, a] = x;
                    x++;
                }
                a++;
                b++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t" + c[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
