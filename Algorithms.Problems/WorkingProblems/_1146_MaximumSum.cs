using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.WorkingProblems
{
    class _1146_MaximumSum
    {
        public static void main()
        {
            short maxSum = short.MinValue;

            short n = short.Parse(Console.ReadLine());

            int[,] matrix = new int[n + 1, n + 1];

            for (int i = 1; i <= n; i++)
            {
                var newLine = Console.ReadLine().Split(' ');

                for (int j = 1; j <= n; j++)
                {
                    matrix[i, j] = int.Parse(newLine[j - 1]);
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                }
            }

            Console.WriteLine(maxSum);

            Console.ReadLine();
        }
    }
}
