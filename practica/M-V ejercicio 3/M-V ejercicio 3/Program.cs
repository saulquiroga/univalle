﻿using System;

namespace M_V_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, n, s;
            Console.WriteLine("ingrese un numero para la serie : ");
            n = Convert.ToInt32(Console.ReadLine());
            string[] f = new string[n];
            q = 0;
            s = 1;
            for(int x = 1; x <= n&&q<n; x++)
            {
                if (x==s)
                {
                    for (int i = 1; i <= x && q < n; i++)
                    {
                        f[q] = "0";
                        q++;
                    }
                    s = s + 3;
                }
                else
                {
                    if (x%2==0)
                    {
                        for(int i = 1; i <= x && q < n; i++)
                        {
                            f[q] = "1";
                            q++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= x && q < n; i++)
                        {
                            f[q] = "#";
                            q++;
                        }
                    }
                }
            }
            for ( int j = 0;j < n; j++)
            {
                Console.Write("\t" + f[j]);
            }
            Console.ReadKey();
        }
    }
}
