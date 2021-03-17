using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class aulaTres
    {
        static void x()
        {
            

            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            Console.WriteLine(result);
            Console.WriteLine();
            int result2 = Calculator.Sum2(10, 20, 30, 40);
            Console.WriteLine(result2);
        }
    }
}
