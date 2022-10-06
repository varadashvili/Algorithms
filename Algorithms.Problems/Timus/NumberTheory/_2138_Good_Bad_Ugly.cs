using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _2138_Good_Bad_Ugly
    {
        public static void main()
        {
            Console.ReadLine();

            long initMessage = long.Parse(Console.ReadLine());

            int z = 256;
            long x = z * z * z;
            int y = z * z;

            long a, b, c, d;

            long message = 0;

            a = (initMessage - (initMessage % x)) / x;

            b = ((initMessage % x) - (initMessage % y)) / y;

            c = ((initMessage % y) - (initMessage % z)) / z;

            d = initMessage % z;

            message = d * x + c * y + b * z + a;

            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
