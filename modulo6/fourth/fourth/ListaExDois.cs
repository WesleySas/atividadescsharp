using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class ListaExDois
    {
        static void x()
        {
            /*
            List<Funcionario> lst = new List<Funcionario>();

            Console.WriteLine("How many employees will be registered? ");
            int employ = int.Parse(Console.ReadLine());

            for(int i = 0; i < employ; i++)
            {
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lst.Add(new Funcionario(id, nome, salary));
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            foreach(Funcionario obj in lst)
            {
                obj.increaseSalary(increase);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Funcionario obj in lst)
            {
                string msg = obj.Msg();
                Console.WriteLine(msg);
            }
            */

            List<Funcionario> lst = new List<Funcionario>();

            Console.WriteLine("How many employees will be registered? ");
            int employ = int.Parse(Console.ReadLine());

            for (int i = 0; i < employ; i++)
            {
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lst.Add(new Funcionario(id, nome, salary));
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //pega o find do LST e o EMP Aponta no Heap onde esta o valor do increase
            Funcionario emp = lst.Find(x => x.Id == increase);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(porcentagem);
            }

            
          

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in lst)
            {
                string msg = obj.Msg();
                Console.WriteLine(msg);
            }

        }
    }
}
