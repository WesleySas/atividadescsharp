using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class ListaExTres
    {
        static void Main()
        {

            int[,] matriz = new int[3, 4];
            Console.WriteLine(matriz);

            for (int i = 0; i < 3; i++)
            {
                string[] v = Console.ReadLine().Split(" ");
                for(int j = 0; j < 4; j++)
                {
                    matriz[i, j] = int.Parse(v[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < 3 - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < 4 - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
