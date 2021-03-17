using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace fourth
{
    class ListaExUm
    {
        static void x(string[] args)
        {
            Console.WriteLine("Quantos quartos serão necessários?");
            int qtQuarto = int.Parse(Console.ReadLine());

            QuartoHotel[] arrayQuarto = new QuartoHotel[qtQuarto];
            int aluguel = 0;
            int quarto;
            for (int i = 0; i < qtQuarto; i++)
            {
                Console.Write("Informe o seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o seu Email: ");
                string email = Console.ReadLine();
                aluguel = aluguel + 1;
           
                do
                {
                    Console.Write("Informe em que quarto deseja ficar: ");
                    quarto = int.Parse(Console.ReadLine());
                } while (quarto > qtQuarto );

                arrayQuarto[quarto] = new QuartoHotel(nome, email, aluguel, quarto);

            }

            for(int i = 0; i < qtQuarto; i++)
            {
                Console.WriteLine($"O Aluguel: {arrayQuarto[i].Quarto}, Nome: {arrayQuarto[i].Name}, Email: {arrayQuarto[i].Email}");
                Console.WriteLine();
            }

        }
    }
}
