using System;

namespace E_R_ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, con, c, n, x;
            do
            {
                Console.Write("introduzca un numero para la serie: ");
                n = Convert.ToInt16(Console.ReadLine());
            } while (n <= 0);
            a = 1;
            b = 0;
            x = 1;
            con = 0;
            c = 1;
            while (con < n)
            {
                if (con % 2 == 0)
                {
                    Console.Write(x);
                    x = x + 2;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write(c);
                }
                con++;
            }
            Console.ReadKey();
        }
    }
}
