using System;

namespace M_V_EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, s, h, i, j, d, sh, max, pos;
            string nom;
            pos = 0;
            do
            {               
                Console.WriteLine("INGRESE EL NUMERO DE CHOFERES");            
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            do
            {
                Console.WriteLine("INGRESE EL SUELDO POR HORA");
                sh = Convert.ToInt32(Console.ReadLine());
            } while (sh <= 0);
            s = 0;

            string[] nombres = new string[n];
            int[,] dias = new int[n, 6];
            int[] total = new int[n];
            int[] sueldo = new int[n];
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
                        Console.WriteLine("INGRESE LAS HORAS TRABAJADAS:");
                        h = Convert.ToInt32(Console.ReadLine());
                    } while (h < 0 || h > 24);
                    dias[i, j] = h;
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
                sueldo[i] = total[i] * sh;
            }
            s = 0;
            for (i = 0; i < n; i++)
            {
                s = s + sueldo[i];
            }
            max = 0;
            for (i = 0; i < n; i++)
            {
                if (dias[i, 0] > max)
                {
                    max = dias[i, 0];
                    pos = i;
                }
                else
                {
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write("\t" + nombres[i]);
                for (j = 0; j < 6; j++)
                {
                    Console.Write("\t" + dias[i, j]);
                }
                Console.Write("\t" + "EL TOTAL DE HORAS ES: ");
                Console.Write(total[i] + "Hrs");
                Console.WriteLine();
                Console.Write("\t" + "EL SUELDO SEMANAL ES: ");
                Console.Write(sueldo[i] + " Bs");
                Console.WriteLine();
            }
            Console.WriteLine("EL DINERO TOTAL QUE PAGARA LA EMPRESA ES:");
            Console.WriteLine(s + " Bs");
            Console.Write("\t" + nombres[pos]);
            Console.WriteLine(" ES EL QUE TRABAJO MAS HORAS QUE SON:" + max);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
