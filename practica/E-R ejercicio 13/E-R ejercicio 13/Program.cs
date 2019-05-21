using System;

namespace E_R_ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1, s, cm, m1, m, ms, c2, c3, rt, m2, sf;
            Console.WriteLine("Ingrese un número para la serie:");
            s = Convert.ToInt32(Console.ReadLine());
            cm = 0;
            ms = 0;
            c1 = 1;
            c2 = 1;
            m1 = 1;
            c3 = 1;
            m2 = 1;
            m = s;
            sf = 0;
            while (c1 <= s)
            {
                cm = cm + 1;
                m1 = Math.Pow(m, cm);
                ms = ms + m1;
                c1 = c1 + 1;
            }
            while (c2 <= s)
            {
                m2 = m2 * c3;
                sf = sf + m2;
                c3 = c3 + 1;
                c2 = c2 + 1;
            }
            rt = ms / sf;
            rt = rt + 1;
            Console.WriteLine("La operación total es:" + rt);
            Console.ReadKey();
        }
    }
}
