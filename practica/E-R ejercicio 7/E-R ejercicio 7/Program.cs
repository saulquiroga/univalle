using System;

namespace E_R_ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, con, c, s, e, ce, p, pf;
            Console.Write("cuantos salones hay en la escuela? ");
            m = Convert.ToInt32(Console.ReadLine());
            con = 1;
            pf = 0;
            ce = 0;
            c = 1;
            while (con <= m)
            {
                Console.WriteLine("cuantos alumnos hay en el salon: " + con);
                s = Convert.ToInt32(Console.ReadLine());
                while (c <= s)
                {
                    do
                    {
                        Console.WriteLine("cual es la edad del alumn@: " + c);
                        e = Convert.ToInt32(Console.ReadLine());
                    } while (e <= 0 || e > 20);
                    ce = ce + e;
                    c++;
                }
                p = ce / s;
                pf = pf + p;
                Console.Write("el promedio de edades en  el salon " + m);
                Console.WriteLine(" es " + p);
                con++;
            }
            pf = pf / m;
            Console.Write("el promedio de edades en toda la escuela es " + pf);
            Console.ReadKey();
        }
    }
}
