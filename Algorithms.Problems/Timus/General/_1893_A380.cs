using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1893_A380
    {
        public static void main()
        {
            string input = Console.ReadLine().Trim();
            string seat = input.ToCharArray()[input.Length - 1].ToString();
            int row = int.Parse(input.Replace(seat, ""));
            string res = "neither";

            if (row < 3)
            {
                if ("AD".Contains(seat))
                    res = "window";
                else
                    res = "aisle";
            }
            else if (row < 21)
            {
                if ("AF".Contains(seat))
                    res = "window";
                else
                    res = "aisle";
            }
            else if (row < 66)
            {
                if ("AK".Contains(seat))
                    res = "window";
                else if ("CDGH".Contains(seat))
                    res = "aisle";
            }

            Console.WriteLine(res);
        }
    }
}
