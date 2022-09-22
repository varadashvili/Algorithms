using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1792_Hamming_Code
    {
        public static void main()
        {
            string input = Console.ReadLine().Trim();
            var arr = Array.ConvertAll(input.Split(' '), int.Parse);

            int isTrue1 = 0;
            int isTrue2 = 0;
            int isTrue3 = 0;

            int val1 = (arr[1] + arr[2] + arr[3]) % 2;
            int val2 = (arr[0] + arr[2] + arr[3]) % 2;
            int val3 = (arr[0] + arr[1] + arr[3]) % 2;

            if (val1 == arr[4])
            {
                isTrue1 = 1;
            }

            if (val2 == arr[5])
            {
                isTrue2 = 1;
            }

            if (val3 == arr[6])
            {
                isTrue3 = 1;
            }

            if (isTrue1 + isTrue2 + isTrue3 < 3)
            {
                if (isTrue1 + isTrue2 + isTrue3 == 1)
                {
                    if (isTrue1 == 1)
                    {
                        arr[0] = (arr[0] + 1) % 2;
                    }
                    else if (isTrue2 == 1)
                    {
                        arr[1] = (arr[1] + 1) % 2;
                    }
                    else if (isTrue3 == 1)
                    {
                        arr[2] = (arr[2] + 1) % 2;
                    }
                }
                else if (isTrue1 + isTrue2 + isTrue3 == 0)
                {
                    arr[3] = (arr[3] + 1) % 2;
                }
                else
                {
                    if (isTrue1 == 0)
                    {
                        arr[4] = val1;
                    }
                    else if (isTrue2 == 0)
                    {
                        arr[5] = val2;
                    }
                    else if (isTrue3 == 0)
                    {
                        arr[6] = val3;
                    }
                }
            }


            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);

            Console.ReadLine();
        }
    }
}
