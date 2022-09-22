using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2066_Simple_Expression
    {
        public static void main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine(-c);
            }
            else if (b == 1)
            {
                Console.WriteLine(a - b - c);
            }
            else
            {
                Console.WriteLine(a - b * c);
            }
        }
    }
}
