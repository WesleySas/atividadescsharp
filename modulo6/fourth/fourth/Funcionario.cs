using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        /*
        public void increaseSalary(double x)
        {
            if(x == Id)
            {
                Console.WriteLine("Enter the percentage: ");
                double i = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Salary = Salary + (Salary * (i / 100));
                Console.WriteLine(" Esse é o i = " + i);

            }
            else
            {
                Console.WriteLine("This id does not exist!");

            }
        }
        */

        public void increaseSalary(double x)
        {

            Salary = Salary + (Salary * (x / 100));

        }

        public string Msg()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2");
        }
    }
}
