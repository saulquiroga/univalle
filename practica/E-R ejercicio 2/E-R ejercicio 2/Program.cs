﻿using System;

namespace E_R_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, CV;
            do
            {
                Console.WriteLine("Cuantos alumnos viajaran?");
                N = Convert.ToInt32(Console.ReadLine());
            }while(N < 0);
            if (N > 0)
            {
                if (N >= 100)
                {
                    CV = N * 20 / N;
                    Console.Write("Cada alumno deberà pagar: " + CV);
                }
                else
                {
                    if (N > 49 && N < 101)
                    {
                        CV = N * 35 / N;
                        Console.Write("Cada alumno deberá pagar: " + CV);
                    }
                    else
                    {
                        if (N > 19 && N < 50)
                        {
                            CV = N * 40 / N;
                            Console.Write("Cada alumno deberà pagar: " + CV);
                        }
                        else
                        {
                            if (N < 20)
                            {
                                CV = N * 70 / N;
                                Console.Write("Cada alumno deberà pagar: " + CV);
                            }
                            else
                            {
                                Console.Write("nadie viajara");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.Write("nadie viajara");
            }
            Console.ReadKey();
        }
    }
}
