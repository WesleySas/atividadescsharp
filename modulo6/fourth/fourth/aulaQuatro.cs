using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class aulaQuatro
    {
        static void x()
        {
            int a = 10;
            Multiplica.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int retronaMult;
            Multiplica.Triple2( b, out retronaMult);
            Console.WriteLine(retronaMult);

            string[] carros = new string[] { "Relampago Mc Gueen", "Fernando Bernunes", "Catchuga", "Math" };
            foreach(string c in carros)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            double[] notas = new double[] { 10, 9.6 , 5.4, 2.6, 6.8, 9.5, 3.6 };
            foreach(double n in notas)
            {
                Console.WriteLine(n);
            }

        }
    }
}
