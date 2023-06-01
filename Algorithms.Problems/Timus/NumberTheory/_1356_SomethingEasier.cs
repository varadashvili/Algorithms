using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _1356_SomethingEasier
    {
        static int limit = 50000;
        static bool[] hasDivisors = new bool[limit];
        static int[] primeNumbers = new int[limit];
        static int primeCount = 0;

        static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i <= Math.Sqrt(n); i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        static bool isPrime_slower(int n)
        {
            if (n == 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static int getFirstPrime(int n)
        {
            for (int i = 2; i < primeCount; i++)
            {
                if (isPrime(n - primeNumbers[i]))
                {
                    return primeNumbers[i];
                }
            }

            return 0;
        }

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
                var checkNumber = int.Parse(Console.ReadLine());

                if (checkNumber == 4)
                {
                    Console.WriteLine("2 2");
                }
                else if (isPrime(checkNumber))
                {
                    Console.WriteLine(checkNumber);
                }
                else if (checkNumber % 2 == 0)
                {
                    int firstPrime = getFirstPrime(checkNumber);

                    Console.WriteLine(firstPrime.ToString() + " " + (checkNumber - firstPrime).ToString());
                }
                else
                {
                    if (isPrime(checkNumber - 2))
                    {
                        Console.WriteLine("2 " + (checkNumber - 2));
                    }
                    else
                    {
                        int firstPrime = getFirstPrime(checkNumber - 3);

                        Console.WriteLine("3 " + firstPrime.ToString() + " " + (checkNumber - 3 - firstPrime).ToString());
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
