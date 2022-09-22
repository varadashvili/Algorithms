using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2005_TaxiForProgrammers
    {
        public static void main()
        {
            int pos = -1; string path = "";
            string[][] input = new string[5][];
            input[0] = Console.ReadLine().Split(' ');
            input[1] = Console.ReadLine().Split(' ');
            input[2] = Console.ReadLine().Split(' ');
            input[3] = Console.ReadLine().Split(' ');
            input[4] = Console.ReadLine().Split(' ');

            int[,] ways = new int[4, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 1, 4, 3, 2, 5 },
                { 1, 3, 2, 4, 5 },
                { 1, 3, 4, 2, 5 }
            };

            int[] sumway = new int[4] { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    sumway[i] += int.Parse(input[ways[i, j - 1] - 1][ways[i, j] - 1]);
                }
            }

            int min = sumway.Min();
            pos = Array.IndexOf(sumway, min);

            Console.WriteLine(sumway[pos]);
            for (int j = 0; j < 5; j++)
                path += ways[pos, j] + " ";
            Console.WriteLine(path.Trim());
        }
    }
}
