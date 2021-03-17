using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class aulaSeis
    {
        static void x()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i < n; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal;");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Temos " + count + " números negativos");
        }
    }
}
