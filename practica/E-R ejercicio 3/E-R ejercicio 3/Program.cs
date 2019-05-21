using System;

namespace E_R_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, c, cc, ca;
            Console.Write("introduzca un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            c = 0;
            cc = 0;
            ca = 0;
            while (n != 0)
            {
                if (n > 0)
                {
                    x = n % 10;
                    n = n / 10;
                    if (x == 0)
                    {
                        cc++;
                    }
                    else
                    {
                        if (x > 0)
                        {
                            ca++;
                        }
                        else
                        {
                            c++;
                        }
                    }
                }
                else
                {
                    if (n != 0)
                    {
                        x = n % 10;
                        n = (n/10) ;
                        n = n * -1;
                        if (x == 0)
                        {
                            cc++;
                        }
                        else
                        {
                            if (x > 0)
                            {
                                ca++;
                            }
                            else
                            {
                                c++;
                            }
                        }
                    }
                    else
                    {
                        x = n % 10;
                        n = n / 10;
                        cc++;
                    }

                }

            }
            Console.Write("el numero cuenta con ");
            Console.Write(cc + " ceros, ");
            Console.Write(ca + " numeros mayor a cero y ");
            Console.Write(c + " numeros menor a cero");
            Console.ReadKey();
        }
    }
}
