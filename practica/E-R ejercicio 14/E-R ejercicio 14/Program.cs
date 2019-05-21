using System;

namespace E_R_ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, c1, n, m, p, d, dt;
            Console.WriteLine("Ingrese un número para la serie:");
            n = Convert.ToInt32(Console.ReadLine());
            m = 0;
            c1 = 1;
            c = 0;
            while (c1 <= n)
            {
                c = c + 1;
                p = c;
                p = p * p;
                m = m + p;
                c1 = c1 + 1;
            }
            d = n * 2;
            dt = m / d;
            Console.WriteLine("El resultado de la series es:" + dt);
            Console.ReadKey();
        }
    }
}
