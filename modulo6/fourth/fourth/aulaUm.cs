using System;
using System.Globalization;


namespace fourth
{
    class aulaUm
    {
        static void x(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double soma = 0.0;
            double media = 0.0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            }
            Console.WriteLine(soma);

            media = soma / n;
            Console.WriteLine("A média é: " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
