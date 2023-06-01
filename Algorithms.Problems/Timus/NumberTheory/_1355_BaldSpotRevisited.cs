using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _1355_BaldSpotRevisited
    {
        static int limit = 31700;
        static bool[] hasDivisors = new bool[limit];
        static int[] primeNumbers = new int[limit];
        static int primeCount = 0;

        public static void main()
        {
            for (long i = 2; i < limit; i++)
            {
                if (!hasDivisors[i])
                {
                    primeCount++;
                    primeNumbers[primeCount] = (int)i;

                    for (long j = i * i; j < limit; j += i)
                    {
                        hasDivisors[j] = true;
                    }
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var a = int.Parse(input[0]);
                var b = int.Parse(input[1]);

                if (b % a == 0)
                {
                    var num = b / a;
                    var ans = 1;

                    for (int j = 1; j <= primeCount && num > 1; j++)
                    {
                        while (num % primeNumbers[j] == 0)
                        {
                            ans++;
                            num = num / primeNumbers[j];
                        }
                    }

                    if (num != 1)
                    {
                        ans++;
                    }

                    Console.WriteLine(ans);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }

            Console.ReadLine();
        }
    }
}
