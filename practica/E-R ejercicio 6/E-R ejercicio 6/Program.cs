using System;

namespace E_R_ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, art, con, d, f;
            con = 1;
            f = 0;
            Console.WriteLine("Cuantos articulos compro ");
            N = Convert.ToInt32(Console.ReadLine());
            while (con<=N)
            {
                do
                {                   
                    Console.WriteLine("cuanto vale el articulo " + con);
                    art = Convert.ToInt32(Console.ReadLine());
                } while (N < 0);
                if (art >= 200)
                {
                    d = art * 15 / 100;
                    art = art - d;
                    con++;
                }
                else
                {
                    if (art > 100 && art < 200)
                    {
                        d = art * 12 / 100;
                        art = art - d;
                        con++;
                    }
                    else
                    {
                        d = art * 12 / 100;
                        art = art - d;
                        con++;
                    }
                }
                Console.Write("el descuento del ariculo es: " + d);
                Console.WriteLine(" y su valor es: " + art);
                f = f + art;
            }
            Console.Write("el precio final de los articulos es: " + f);
            Console.ReadKey();
        }
    }
} 