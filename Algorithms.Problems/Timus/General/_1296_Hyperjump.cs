using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1296_Hyperjump
    {
        public static void main()
        {
            int maxGravity = 0;
            int lastGravity = 0;
            int curGravity = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                curGravity = int.Parse(Console.ReadLine()) + lastGravity;

                if (curGravity > 0)
                {
                    lastGravity = curGravity;
                }
                else
                {
                    lastGravity = 0;
                }

                maxGravity = Math.Max(maxGravity, lastGravity);
            }

            Console.WriteLine(maxGravity);

            Console.ReadLine();
        }
    }
}
