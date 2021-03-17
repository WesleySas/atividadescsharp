using System;
using System.Collections.Generic;
using System.Text;
namespace fourth
{
    class AulaCincoList
    {
        static void X()
        {
            List<string> lst = new List<string>();

            lst.Add("Cleitin");
            lst.Add("Juninho Botafé");
            lst.Add("Robeilton");
            lst.Add("Gui terror");
            lst.Add("Robert fuga");
            lst.Add("Alek Fumaça");

            foreach (string bonde in lst)
            {
                Console.WriteLine(bonde);
            }
            Console.WriteLine(lst.Count);
            Console.WriteLine();

            string f1 = lst.Find(y => y[0] == 'R'); //  Primeiro elemento
            Console.WriteLine("Primeiro delinquente " + f1);

            string f2 = lst.FindLast(b => b[0] == 'R'); //  Ultimo elemento 
            Console.WriteLine("Último delinquente "+ f2);

            int posicaoF1 = lst.FindIndex(y => y[0] == 'R'); // acha posicção na lista
            Console.WriteLine(posicaoF1);

            List<string> lst2 = lst.FindAll(y => y.Length == 5);
            Console.WriteLine("-------------------------------------------");
            foreach(string b in lst2)
            {
                Console.WriteLine(b);
            }

            lst.Remove("Juninho Botafé");
            Console.WriteLine("-------------------------------------------");
            foreach(string p in lst)
            {
                Console.WriteLine(p);
            }

            lst.RemoveAll(x => x[0] == 'R');
            Console.WriteLine("-------------------------------------------");
            foreach (string p in lst)
            {
                Console.WriteLine(p);
            }


        }
    }
}
