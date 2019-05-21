using System;

namespace E_R_ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q, N;
            float C1, C, C3, C4;
            Console.WriteLine("ingrese un numero para la serie : ");
            N = Convert.ToInt32(Console.ReadLine());
            C1 = 0;
            C = 0;
            C3 = 0;
            C4 = 0;
            do
            {
                C3 = C3 + 1;
                if (C1 == 3)
                {
                    C1 = 0;
                }
                else { }

                C1 = C1 + 1;
                if (C1 == 1)
                {
                    Q = 1;
                }
                else
                {
                    Q = 0;
                }
                C = C3;
                while ((C > 0) && (N > C4))
                {
                    C = C - 1;
                    if (C1 == 3)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(Q);
                    }
                    C4 = C4 + 1;
                }
            } while (N > C3);
            Console.ReadKey();
        }
    }
}
