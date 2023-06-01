using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _2102_MichaelAndCryptography
    {
        static long divisors = 0;
        static long maxDivisor = 2000000;

        static void FindDivisors(long n)
        {
            long m = n;

            if (n == 1)
                return;

            if (divisors > 20)
                return;

            for (long i = 3; (i * i <= n) && (i < maxDivisor); i = i + 2)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        divisors++;
                        n = n / i;
                    }

                    break;
                }
            }

            if (n == m)
            {
                divisors++;
            }
            else
            {
                FindDivisors(n);
            }
        }

        public static void main()
        {
            long n = long.Parse(Console.ReadLine());

            while (n % 2 == 0)
            {
                divisors++;
                n = n / 2;
            }

            FindDivisors(n);

            if (divisors != 20)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("Yes");
            }

            Console.ReadLine();
        }
    }
}
