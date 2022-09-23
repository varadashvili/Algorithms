using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1512_Zinium
    {
        public static void main()
        {
            long n, i, j, rem;
            long[] a = new long[100001];

            n = long.Parse(Console.ReadLine());

            rem = n % 12;

            if ((rem == 3) || (rem == 9))
            {
                i = 4;
            }
            else
            {
                i = 2;
            }

            j = 1;

            for (; i <= n; i = i + 2)
            {
                a[j] = i;
                j = j + 1;
            }

            if (a[1] == 4)
            {
                a[j] = 2;
                j = j + 1;
            }

            if ((rem == 3) || (rem == 9))
            {
                for (i = 5; i <= n; i = i + 2)
                {
                    a[j] = i;
                    j = j + 1;
                }
                a[j] = 1;
                a[j + 1] = 3;
            }

            if (rem == 2)
            {
                a[j] = 3;
                a[j + 1] = 1;
                j = j + 2;
                for (i = 7; i <= n; i = i + 2)
                {
                    a[j] = i;
                    j = j + 1;
                }
                a[j] = 5;
            }

            if (rem == 8)
            {
                for (i = 3; i <= n; i = i + 4)
                {
                    a[j] = i;
                    a[j + 1] = i - 2;
                    j = j + 2;
                }
            }

            if ((rem != 3) && (rem != 9) && (rem != 2) && (rem != 8))
            {
                for (i = 1; i <= n; i = i + 2)
                {
                    a[j] = i;
                    j = j + 1;
                }
            }
            /******************************************************************************/
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + a[i]);
            }
        }
    }
}
