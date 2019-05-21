using System;

namespace E_R_ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, v, c, cc, dd, m1, m2, m5, total;
            Console.Write("cuantos billetes de diez hay: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantos billetes de veinte hay: ");
            v = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantos billetes de cincuenta hay: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantos billetes de cien hay: ");
            cc = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantos billetes de docientos hay: ");
            dd = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantas monedas de uno hay: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantas monedas de 2 hay: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantas monedas de 5 hay : ");
            m5 = Convert.ToInt32(Console.ReadLine());
            total = d + v + c + cc + dd + m1 + m2 + m5;
            Console.Write("en la caja resgistradora hay " + total);
            Console.Write(" bs");
            Console.ReadKey();           
        }
    }
}
