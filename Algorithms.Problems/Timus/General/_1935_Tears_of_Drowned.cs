using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1935_Tears_of_Drowned
    {
        public static void main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            string input = Console.ReadLine().Trim();
            var arr = Array.ConvertAll(input.Split(' '), int.Parse);

            var sum = arr.Max() + arr.Sum();

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
