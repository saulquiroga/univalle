using System;

namespace E_R_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  v, b, r, x, c, con;
            do
            {
                Console.Write("cuantos focos hay en el lote? ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x <= 0);
            con = 1;
            v = 0;
            b = 0;
            r =0;
            while (con<=x)
            {
                do
                {
                    Console.WriteLine("saque el foco "+con);
                    Console.WriteLine("si el foco es verde coloque 1, si el foco es rojo coloque 2 y si el foco es blanco coloque 3");
                    c = Convert.ToInt32(Console.ReadLine());
                } while (c > 3 || c < 0);
                if(c==1)
                {
                    v++;
                    con++;
                }
                else
                {
                    if (c==2)
                    {
                        r++;
                        con++;
                    }
                    else
                    {
                        b++;
                        con++;
                    }
                }
            }
            Console.Write("en un lote de " + x);
            Console.Write(" focos, hay " + v);
            Console.Write(" focos verdes, " + b);
            Console.Write(" focos blancos " + r);
            Console.Write(" y focos rojos");
            Console.ReadKey();
        }
    }
}

