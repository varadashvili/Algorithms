using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1198_Jobbery
    {
        /*****************************************************************************/
        public partial class TarjanTreeNode
        {
            public int id;
            public int index;
            public int lowLink;
            public bool onStack;
            public List<TarjanTreeNode> adjacents;
        }

        public static SortedSet<int> LastSSC;
        public static Stack<int> stack = new Stack<int>();
        static int index = 1;
        public static void TarjanSSC(List<TarjanTreeNode> G)
        {
            foreach (TarjanTreeNode v in G)
            {
                if (v.index < 0)
                {
                    StrongConnect(v);
                }
            }
        }

        private static void StrongConnect(TarjanTreeNode v)
        {
            v.index = index;
            v.lowLink = index;
            index++;
            stack.Push(v.id);
            v.onStack = true;

            foreach (TarjanTreeNode w in v.adjacents)
            {
                if (w.index < 0)
                {
                    StrongConnect(w);
                    v.lowLink = Math.Min(v.lowLink, w.lowLink);
                }
                else if (w.onStack)
                {
                    v.lowLink = Math.Min(v.lowLink, w.index);
                }
            }


            if (v.lowLink == v.index)
            {
                LastSSC = new SortedSet<int>();
                int w;
                do
                {
                    w = stack.Pop();
                    martains[w - 1].onStack = false;
                    LastSSC.Add(w);
                } while (v != martains[w - 1]);
            }

        }

        /*****************************************************************************/

        static int res = 1;
        private static void DFSvisit2(TarjanTreeNode u)
        {
            u.index = -2;

            foreach (var g in u.adjacents)
            {
                if (g.index != -2)
                {
                    res++;
                    DFSvisit2(g);
                }
            }

        }
        /*****************************************************************************/

        static TarjanTreeNode[] martains;
        public static void main()
        {
            int n = int.Parse(Console.ReadLine());
            martains = new TarjanTreeNode[n];

            for (int i = 1; i <= n; i++)
            {
                TarjanTreeNode node = new TarjanTreeNode
                {
                    id = i,
                    index = -1,
                    onStack = false,
                    adjacents = new List<TarjanTreeNode>()
                };
                martains[i - 1] = node;
            }

            for (int i = 1; i <= n; i++)
            {
                var node = martains[i - 1];

                var input = Console.ReadLine().Split(' ');
                foreach (string s in input)
                {
                    if (s != "0")
                        node.adjacents.Add(martains[int.Parse(s) - 1]);
                }
            }

            TarjanSSC(martains.ToList());
            var tnode = martains[LastSSC.First() - 1];
            DFSvisit2(tnode);

            if (res == n)
            {
                foreach (var x in LastSSC)
                    Console.Write(x + " ");
                //LastSSC.ToList().ForEach(x => Console.Write(x + " "));
            }
            Console.Write("0");
        }
    }
}
