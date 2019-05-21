using System;

namespace E_R_ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, v, dm, dd, md, e1, e2, e3, total;
            con = 1;
            e1 = 0;
            e2 = 0;
            e3 = 0;
            dm = 0;
            dd = 0;
            md = 0;
            Console.WriteLine("cuantas ventas realizo? ");
            n = Convert.ToInt32(Console.ReadLine());
            while (con <= n)
            {
                Console.WriteLine("cuanto valio venta: "+con);
                v = Convert.ToInt32(Console.ReadLine());
                if (v <= 10000)
                {
                    dm++;
                    con++;
                    e1 = e1 + v;
                }
                else
                {
                    if (v > 10000 && v < 20000)
                    {
                        dd++;
                        con++;
                        e2 = e2 + v;
                    }
                    else
                    {
                        md++;
                        con++;
                        e3 = e3 + v;
                    }
                }
            }
            total = e1 + e2 + e3;
            Console.Write("se realizo " + dm);
            Console.WriteLine(" ventas de 10000 a menos y su total fue: " + e1);
            Console.Write("se realizo " + dd);
            Console.WriteLine(" ventas de 10000 a mas o 20000 a menos  y su total fue: " + e2);
            Console.Write("se realizo " + md);
            Console.WriteLine(" ventas de 20000 a mas y su total fue: " + e3);
            Console.Write(" el total de las ventas es : " +total );
            Console.ReadKey();
        }
    }
}
