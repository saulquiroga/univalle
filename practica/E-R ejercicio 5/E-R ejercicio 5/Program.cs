using System;

namespace E_R_ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int d,c ;
            Console.Write("cuanto dinero ahorro el pirmer dia? ");
            d = Convert.ToInt32(Console.ReadLine());
            c = 1;    
            d = d * 365;
            Console.WriteLine("anualmente se ahorro " + d);
            Console.ReadKey();
        }
    }
}
