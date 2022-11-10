using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2149_PigeonholePrinciple
    {
        public static void main()
        {
            int n = int.Parse(Console.ReadLine());

            var line1 = Console.ReadLine().Replace("@", "").Replace(".", "");

            char s1 = '<';
            char s2 = '>';

            int a1 = 0;
            int a2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (line1[i - 1] != s1)
                {
                    a1++;
                }

                if (line1[i - 1] != s2)
                {
                    a2++;
                }

                if (i >= n / 2)
                {
                    s1 = '>';
                }

                s2 = s2 == '>' ? '<' : '>';
            }

            if (a1 > n / 2)
            {
                a1 = n - a1;
            }

            if (a2 > n / 2)
            {
                a2 = n - a2;
            }

            Console.WriteLine(Math.Min(a1,a2));

            Console.ReadLine();
        }
    }
}
