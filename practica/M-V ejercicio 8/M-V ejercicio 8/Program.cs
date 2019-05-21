using System;

namespace M_V_ejercicio_8
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
            int[,] c = new int[n, n];
            x = 1;
            a = 0;
            b = 1;
            while (x <= n * n)
            {
                for (int j = 0; j < n - a; j++)
                {
                    c[a, j] = x;
                    x++;
                }
                for (int i = b; i < n; i++)
                {
                    c[i, n- b] = x;
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
