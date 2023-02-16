using System;

namespace Algorithms.Problems.Timus.DynamicProgramming
{
    class _1146_MaximumSum
    {
        public static void main()
        {
            int maxSum = int.MinValue;

            short n = short.Parse(Console.ReadLine());

            int[,] matrix = new int[n + 1, n + 1];
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                var newLine = Console.ReadLine().Split(' ');

                for (int j = 1; j <= n; j++)
                {
                    matrix[i, j] = matrix[i, j - 1] + int.Parse(newLine[j - 1]);
                }
            }

            for (int startColumn = 1; startColumn <= n; startColumn++)
            {
                for (int endColumn = startColumn; endColumn <= n; endColumn++)
                {
                    for (int rowIndex = 1; rowIndex <= n; rowIndex++)
                    {
                        int currentSlice = matrix[rowIndex, endColumn] - matrix[rowIndex, startColumn - 1];

                        dp[rowIndex] = currentSlice + Math.Max(0, dp[rowIndex - 1]);

                        maxSum = Math.Max(maxSum, dp[rowIndex]);
                    }
                }
            }

            Console.WriteLine(maxSum);

            Console.ReadLine();
        }
    }
}