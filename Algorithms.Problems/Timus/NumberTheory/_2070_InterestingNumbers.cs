using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    public class _2070_InterestingNumbers
    {
        public static void main()
        {
            long limit = 1000001;
            bool[] hasDivisors = new bool[limit];
            long[] primeNumbers = new long[limit];
            long ans;
            int primeCount = 0;

            var input = Console.ReadLine().Split(' ');

            long start = long.Parse(input[0]);
            long end = long.Parse(input[1]);

            if (start == end && start == 1)
            {
                Console.WriteLine("1");

                return;
            }

            for (long i = 2; i < limit; i++)
            {
                if (!hasDivisors[i])
                {
                    primeCount++;
                    primeNumbers[primeCount] = i;

                    for (long j = i * i; j < limit; j += i)
                    {
                        hasDivisors[j] = true;
                    }
                }
            }

            ans = end - start + 1;
            long num;
            int pow;

            for (int i = 1; i <= primeCount; i++)
            {
                pow = 2;
                num = primeNumbers[i] * primeNumbers[i];

                while (num < start)
                {
                    num *= primeNumbers[i];
                    pow++;
                }

                while (num <= end)
                {
                    if (!hasDivisors[pow + 1])
                    {
                        ans--;
                    }
                    num *= primeNumbers[i];
                    pow++;
                }
            }


            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
