using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2056_Scholarship
    {
        public static void main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            if (n == 1)
            {
                Console.WriteLine("11");
            }
            else if (n == 2)
            {
                Console.WriteLine("11 01");
            }
            else if (n == 3)
            {
                Console.WriteLine("06 68 88");
            }
            else if (n == 4)
            {
                Console.WriteLine("16 06 68 88");
            }
            else
            {
                Console.WriteLine("Glupenky Pierre");
            }
        }
    }
}
