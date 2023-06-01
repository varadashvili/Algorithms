using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    public class _1118_NontrivialNumbers
    {
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);

            int[] divisorSum = new int[1000001];

            decimal minFactor = int.MaxValue;
            int minFactorNumber = int.MaxValue;

            if (start == 1)
            {
                Console.WriteLine(1);

                return;
            }

            for (int i = 2; i <= end; i++)
            {
                divisorSum[i]++;

                for (int j = i + i; j <= end; j = j + i)
                {
                    divisorSum[j] += i;
                }

                var iFactor = (decimal)divisorSum[i] / (decimal)i;
                if (iFactor < minFactor && i >= start)
                {
                    minFactor = iFactor;
                    minFactorNumber = i;
                }
            }

            Console.WriteLine(minFactorNumber);

            Console.ReadLine();
        }
    }
}
