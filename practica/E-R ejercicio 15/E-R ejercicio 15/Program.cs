﻿using System;

namespace E_R_ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cn, cnn, m, c, cf0, cf1, r, rt, ct;
            Console.WriteLine("Ingrese un número para la serie: ");
            n = Convert.ToInt32(Console.ReadLine());
            cf1 = 1;
            cn = 0;
            rt = 0;
            ct = 1;
            do
            {
                cf0 = 1;
                cn = cn + 1;
                cnn = -cn;
                m = 1;
                c = 1;
                while (cf0 <= cf1)
                {
                    m = m * c;
                    c = c + 1;
                    cf0 = cf0 + 1;
                }
                cf1 = cf1 + 1;
                r = cnn + m;
                rt = rt + r;
                ct = ct + 1;
            } while (ct <= n);
            Console.WriteLine(+rt);
            Console.ReadKey();
        }
    }
}
