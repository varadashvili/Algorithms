using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2035_Another_Dress_Rehearsal
    {
        public static void main()
        {
            string input = Console.ReadLine();

            var arr = input.Split(' ');

            bool swaped = false;

            long a = long.Parse(arr[0]);
            long b = long.Parse(arr[1]);
            long c = long.Parse(arr[2]);

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;

                swaped = true;
            }

            if (c / 2 > b)
            {
                Console.WriteLine("Impossible");
            }
            else if (c <= b)
            {
                if (swaped)
                {
                    Console.WriteLine("{0} 0", c);
                }
                else
                {
                    Console.WriteLine("0 {0}", c);
                }
            }
            else
            {
                var d = c - b;
                if (d <= a)
                {
                    if (swaped)
                    {
                        Console.WriteLine("{0} {1}", b, d);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", d, b);
                    }
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}
