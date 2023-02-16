using System;

namespace Algorithms.Problems.Timus.NumberTheory
{
    class _1104_DontAskWomanAboutHerAge
    {
        public static void main()
        {
            long digitSum = 0;
            long minBase = 0;
            string output = "No solution.";

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                long x = (int)input[i];

                if (x >= 65 && x <= 90)
                    x = x - 55;

                if (x >= 48 && x <= 57)
                    x = x - 48;

                if (x >= minBase)
                    minBase = x + 1;

                digitSum += x;
            }

            if (digitSum < 2)
            {
                output = "2";
            }
            else
            {
                for (long i = minBase; i <= 36; i++)
                {
                    if (digitSum % (i - 1) == 0)
                    {
                        output = i.ToString();
                        break;
                    }
                }
            }

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
