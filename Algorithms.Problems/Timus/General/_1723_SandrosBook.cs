using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1723_SandrosBook
    {
        public static void main()
        {
            var inp = Console.ReadLine().ToList();
            var a = inp.GroupBy(x => x).Select(t => new { val = t.Key, cnt = t.Count() }).OrderByDescending(o => o.cnt).First().val;
            Console.WriteLine(a);
        }
    }
}
