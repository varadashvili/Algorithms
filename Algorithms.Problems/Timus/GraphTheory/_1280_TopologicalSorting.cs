using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1280_TopologicalSorting
    {
        public partial class DFSTreeNode
        {
            public int pos;
            public bool visited;
            public List<DFSTreeNode> adjacents;
        }

        public static bool DFS(List<DFSTreeNode> G)
        {
            foreach (var g in G)
            {
                if (!g.visited)
                    if (!DFSvisit(g)) return false;
            };
            return true;
        }
        private static bool DFSvisit(DFSTreeNode u)
        {
            u.visited = true;

            if (u.adjacents != null)
            {
                foreach (var g in u.adjacents)
                {
                    if (g.pos < u.pos) return false;
                    if (!g.visited)
                    {
                        if (!DFSvisit(g)) return false;
                    }
                }
            }

            return true;
        }

        static Dictionary<int, DFSTreeNode> subjects = new Dictionary<int, DFSTreeNode>();
        public static void main2()
        {
            var input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int i = 1; i <= n; i++)
            {
                DFSTreeNode node = new DFSTreeNode() { visited = false };
                subjects.Add(i, node);
            }

            for (int i = 0; i < m; i++)
            {
                var inp = Console.ReadLine().Split(' ');
                var node1 = subjects[int.Parse(inp[0])];
                var node2 = subjects[int.Parse(inp[1])];

                if (node1.adjacents == null)
                    node1.adjacents = new List<DFSTreeNode>();

                node1.adjacents.Add(node2);
            }

            var order = Console.ReadLine().Split(' ');
            for (int i = 1; i <= n; i++)
            {
                subjects[int.Parse(order[i - 1])].pos = i;
            }

            if (DFS(subjects.Values.ToList()))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }

        //uketesi varianti
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');
            short n = short.Parse(input[0]);
            int m = int.Parse(input[1]);

            short[] subs = new short[n + 1];
            short[,] pre = new short[m, 2];
            for (int i = 0; i < m; i++)
            {
                var s = Console.ReadLine().Split(' ');
                pre[i, 0] = short.Parse(s[0]);
                pre[i, 1] = short.Parse(s[1]);
            }

            var order = Console.ReadLine().Split(' ');
            for (short i = 1; i <= n; i++)
            {
                subs[short.Parse(order[i - 1])] = i;
            }

            for (int i = 0; i < m; i++)
            {
                if (subs[pre[i, 0]] > subs[pre[i, 1]])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
