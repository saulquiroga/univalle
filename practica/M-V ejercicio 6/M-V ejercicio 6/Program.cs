using System;

namespace M_V_ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, a, b;
            do
            {
                Console.WriteLine("INTRODUZCA UN NUMERO:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1);
            int[] tam_fila = new int[n];
            int[] tam_columna = new int[n];
            int[,] mat = new int[n, n];
            x = 1;
            a = 0;
            b = 0;
            if (n%2==0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = 0;
                    }
                }

                for (int i = 0; i < (n / 2) + 1; i++)
                {
                    x = 1;
                    for (int j = a; j < n - b; j++)
                    {
                        mat[i, j] = x;
                        x++;
                    }
                    a++;
                    b++;
                }
                a = 1;
                b = 2;
                for (int i = (n / 2); i < n; i++)
                {
                    x = 1;
                    for (int j = (n / 2) - a; j < (n / 2) + a ; j++)
                    {
                        mat[i, j] = x;
                        x++;
                    }
                    a++;
                    b++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\t" + mat[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = 0;
                    }
                }

                for (int i = 0; i < (n / 2) + 1; i++)
                {
                    x = 1;
                    for (int j = a; j < n - b; j++)
                    {
                        mat[i, j] = x;
                        x++;
                    }
                    a++;
                    b++;
                }
                a = 1;
                b = 2;
                for (int i = (n / 2) + 1; i < n; i++)
                {
                    x = 1;
                    for (int j = (n / 2) - a; j < (n / 2) + b; j++)
                    {
                        mat[i, j] = x;
                        x++;
                    }
                    a++;
                    b++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\t" + mat[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
