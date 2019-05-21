using System;

namespace M_V_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s, k, i, j, d;

            string nom;
            do
            {
                Console.WriteLine("INGRESE EL NUMERO DE CHOFERES");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            s = 0;
            string[] nombres = new string[n];
            int[,] dias = new int[n, 6];
            int[] total = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine("INGRESE EL NOMBRE DEL CHOFER");
                nom = Convert.ToString(Console.ReadLine());
                nombres[i] = nom;
                for (j = 0; j < 6; j++)
                {
                    do
                    {
                        Console.WriteLine("INGRESE KILOMETROS RECORRIDOS:");
                        k = Convert.ToInt32(Console.ReadLine());
                    } while (k <= 0);
                    dias[i, j] = k;
                }
            }
            for (i = 0; i < n; i++)
            {
                s = 0;
                for (j = 0; j < 6; j++)
                {
                    s = s + dias[i, j];
                }
                total[i] = s;
            }
            for (i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write("\t" + nombres[i]);
                for (j = 0; j < 6; j++)
                {
                    Console.Write("\t" + dias[i, j]);
                }
                Console.Write("\t" );
                Console.Write(total[i] + "Km");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
