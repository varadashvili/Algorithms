using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Codeforces
{
    class _500A_NewYearTransportation
    {
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int t = int.Parse(input[1]);

            var s = Console.ReadLine().Split(' ');
            int pos = 1;

            for (int i = 1; i <= n; i++)
            {
                if (pos == t)
                {
                    Console.WriteLine("YES");
                    return;
                }
                if (pos > t)
                {
                    Console.WriteLine("NO");
                    return;
                }
                if (pos < t && i == pos && i != n)
                {
                    pos = pos + int.Parse(s[i - 1]);
                }
            }

            Console.WriteLine("NO");
        }
    }
}
