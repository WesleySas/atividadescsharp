﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class RespExUm
    {
        static void x()
        {
            Estudante[] vt = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel {i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vt[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vt[i] != null)
                {
                    Console.WriteLine(i + ": " + vt[i]);
                }
            }
        }
    }
}
