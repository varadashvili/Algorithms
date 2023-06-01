using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _1133_FibonacciSequence
    {
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');

            int i = int.Parse(input[0]);
            int j = int.Parse(input[2]);
            long fi = long.Parse(input[1]);
            long fj = long.Parse(input[3]);

            int n = int.Parse(input[4]);

            if (i == n)
            {
                Console.WriteLine(fi);

                return;
            }

            if (j == n)
            {
                Console.WriteLine(fj);

                return;
            }

            if (i > j)
            {
                int k = j; j = i; i = k;

                long kk = fj; fj = fi; fi = kk;
            }

            int t = Math.Min(n, i);
            if (t < 0)
            {
                i += Math.Abs(t);
                j += Math.Abs(t);
                n += Math.Abs(t);
            }


            long startSeek = int.MinValue;
            long endSeek = int.MaxValue;
            long seek;

            long fib1, fib2, fib3;

            while (true)
            {
                seek = (startSeek + endSeek) / 2L;

                fib1 = fi;
                fib2 = seek;
                fib3 = seek;
                for (int idx = i + 2; idx <= j; idx++)
                {
                    fib3 = fib2 + fib1;
                    fib1 = fib2;
                    fib2 = fib3;

                    if (fib3 > int.MaxValue || fib3 < int.MinValue)
                    {
                        break;
                    }
                }

                if (fib3 != fj)
                {
                    if (seek == endSeek || endSeek == startSeek)
                    {
                        return;
                    }

                    if (fib3 > fj)
                    {
                        endSeek = seek;
                    }
                    else
                    {
                        startSeek = seek;
                    }

                    continue;
                }

                if (n > i)
                {
                    fib1 = fi;
                    fib2 = seek;
                    fib3 = seek;

                    for (int idx = i + 2; idx <= n; idx++)
                    {
                        fib3 = fib2 + fib1;
                        fib1 = fib2;
                        fib2 = fib3;
                    }

                    Console.WriteLine(fib3);

                    break;
                }
                else
                {
                    fib1 = seek;
                    fib2 = fi;
                    fib3 = fi;

                    for (int idx = i - 1; idx >= n; idx--)
                    {
                        fib3 = fib1 - fib2;
                        fib1 = fib2;
                        fib2 = fib3;
                    }

                    Console.WriteLine(fib3);

                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
