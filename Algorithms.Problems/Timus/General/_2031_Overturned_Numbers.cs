using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2031_Overturned_Numbers
    {
        public static void main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            List<int> marks = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                marks.Add(int.Parse(Console.ReadLine().Trim()));
            }

            if (!marks.Any(x => x != 5))
            {
                Console.WriteLine("Named");
            }
            else if (marks.Any(x => x == 3))
            {
                Console.WriteLine("None");
            }
            else if (marks.Average() >= 4.5)
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
