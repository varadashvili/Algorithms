using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.DataStructures
{
    class _1654_CipherMessage
    {
        public static void main()
        {
            string input = Console.ReadLine().Trim();
            char[] res = input.ToCharArray();
            int pos = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (pos == -1)
                {
                    pos = 0; res[pos] = input[i];
                }
                else
                {
                    if (res[pos] == input[i])
                        pos -= 1;
                    else
                    {
                        res[pos + 1] = input[i];
                        pos += 1;
                    }
                }
            }
            string s = new string(res);
            Console.WriteLine(s.Substring(0, pos + 1));
        }
    }
}
