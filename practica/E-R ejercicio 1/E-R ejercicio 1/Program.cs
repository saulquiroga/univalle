﻿using System;

namespace E_R_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, p;
            do
            {
                Console.WriteLine("introduzca su edad:");
                e = Convert.ToInt32(Console.ReadLine());
            } while (e <= 0);
            do
            {
                Console.WriteLine("introduzca el promedio");
                p = Convert.ToInt32(Console.ReadLine());
            } while (p < 0 || p>100);
            if (e >= 18)
            {
                if (p >= 90)
                {
                    Console.WriteLine("usted recibira una beca de $2000.00");
                }
                else
                {
                    if (p >= 75)
                    {
                        Console.WriteLine("usted recibira una beca de $1000.00");
                    }
                    else
                    {
                        if (p < 75 && p == 60)
                        {
                            Console.WriteLine("usted recibira una beca de $500.00");
                        }
                        else
                        {
                            Console.WriteLine("estudie más en el próximo ciclo escolar");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("necesita 18 años como minimo para la beca");
            }
            Console.ReadKey();
        }
    }
}
