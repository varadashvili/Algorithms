using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1925_BritishScientistsSaveTheWorld
    {
        public static void main()
        {
            var input = Console.ReadLine().Trim().Split(' ');
            string[] tempinput;
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]) - 2;

            int res = -2 * n;

            for (int i = 1; i <= n; i++)
            {
                tempinput = Console.ReadLine().Trim().Split(' ');
                res += int.Parse(tempinput[0]) - int.Parse(tempinput[1]);
            }

            if (k + res < 0)
                Console.WriteLine("Big Bang!");
            else
                Console.WriteLine(k + res);
        }
    }
}
