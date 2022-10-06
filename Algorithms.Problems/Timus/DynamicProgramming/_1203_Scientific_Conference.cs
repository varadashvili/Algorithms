using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.DynamicProgramming
{
    class _1203_Scientific_Conference
    {
        public static void main()
        {
            int maxReports = 0;
            int maxReportsIndex = 0;

            int n = int.Parse(Console.ReadLine());

            int[] reports = new int[30001];

            for (int i = 1; i <= n; i++)
            {
                var newLine = Console.ReadLine().Split(' ');

                var start = int.Parse(newLine[0]);
                var end = int.Parse(newLine[1]);

                reports[end] = Math.Max(reports[end], start);
            }

            for (int i = 1; i <= 30000; i++)
            {
                if (reports[i] > 0 && reports[i] > maxReportsIndex)
                {
                    maxReports++;
                    maxReportsIndex = i;
                }
            }


            Console.WriteLine(maxReports);

            Console.ReadLine();
        }
    }
}
