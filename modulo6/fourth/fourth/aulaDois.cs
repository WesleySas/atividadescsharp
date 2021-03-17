using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace fourth
{
    class aulaDois
    {
        static void x(string[] args)
        {
           
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vt = new Product[n]; //tamanho do array de produto

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nm = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double pr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vt[i] = new Product(nm, pr);
            }

            double soma = 0;
             
            for (int i = 0; i < n; i++)
            {
                soma += vt[i].price;
            }

            double average = soma / n;
            Console.WriteLine("A média é: " + average);
        }
    }
}
