using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class Multiplica
    {

        public static void Triple(ref int a)
        {
            a = a * 3;
        }

        public static void Triple2(int origin, out int res)
        {
            res = origin * 3;
        }

    }
}
