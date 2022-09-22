using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2001_MathematiciansAndBerries
    {
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');
            int res2 = short.Parse(input[1]) - short.Parse(Console.ReadLine().Split(' ')[1]);
            int res1 = short.Parse(input[0]) - short.Parse(Console.ReadLine().Split(' ')[0]);

            Console.WriteLine(res1 + " " + res2);
        }
    }
}
