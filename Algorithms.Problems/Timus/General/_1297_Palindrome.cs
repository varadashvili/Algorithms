using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1297_Palindrome
    {
        public static void main()
        {
            var input = Console.ReadLine();
            var n = input.Length;

            string message = "|";

            (int start, int end) PalindromeIdx = (0, 0);

            foreach (char c in input)
            {
                message += c + "|";
            }

            var m = message.Length;

            for (int i = 1; i < m; i++)
            {
                int k = 1;

                for (k = 1; i - k >= 0 && i + k < m; k++)
                {
                    if (message[i - k] != message[i + k])
                    {
                        break;
                    }
                }

                k--;

                if (2*k > PalindromeIdx.end - PalindromeIdx.start)
                {
                    PalindromeIdx = (i - k, i + k);
                }
            }

            var Palindrome = message.Substring(PalindromeIdx.start, PalindromeIdx.end - PalindromeIdx.start).Replace("|","");

            Console.WriteLine(Palindrome);

            Console.ReadLine();
        }
    }
}
