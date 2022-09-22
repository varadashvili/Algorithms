using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2100_Wedding_Dinner
    {
        public static void main()
        {
            int a = int.Parse(Console.ReadLine());
            int cnt = 2;

            for (int i = 1; i <= a; i++)
            {
                cnt++;
                if (Console.ReadLine().Contains('+'))
                {
                    cnt++;
                }
            }

            if (cnt == 13)
            {
                cnt++;
            }

            Console.WriteLine(cnt * 100);
        }
    }
}
