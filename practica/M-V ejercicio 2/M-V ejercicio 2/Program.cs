﻿using System;

namespace M_V_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, k, x, e, i, y, z;
            string n;
            i = 1;
            z = 0;
            j = 100;
            y = 0;
            do
            {
                Console.Write("cuantas personas desea registrar: ");
                k = Convert.ToInt32(Console.ReadLine());
            } while (k < 0);
            int[] edades = new int[k];
            string[] nombres = new string[k];
            for (x=0;x<k;x++)
            {
                Console.Write("introduzca el nombre: ");
                n = Console.ReadLine();
                do
                {
                    Console.Write("introduzca la edad: ");
                    e = Convert.ToInt32(Console.ReadLine());
                } while (e < 0 || e > 100);
                do
                {
                    nombres[x] = n;
                    edades[x] = e;
                    if (e > 1)
                    {
                        e = i;
                        y = x;
                    }
                    else
                    {
                        if (e < j)
                        {
                            e = j;
                            z = x;
                        }
                    }
                } while (i == 0 || j == 100);
            }
            Console.Write("el mayor es " + nombres[y] + "\t" + edades[y]);
            Console.WriteLine();
            Console.Write("el menor es " + nombres[z] + "\t" + edades[z]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
