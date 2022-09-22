using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1617_FlatSpots
    {
        public static void main()
        {
            var input = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var cnt = input.GroupBy(x => x).Select(y => y.Count() / 4).Sum();
            Console.WriteLine(cnt);
        }
    }
}
