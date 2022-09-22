using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1272_NonYekaterinburgSubway
    {
        public partial class DFSTreeNode
        {
            public bool visited;
            public List<DFSTreeNode> adjacents;
        }

        static SortedList<int, DFSTreeNode> islands = new SortedList<int, DFSTreeNode>();

        static int n, k, m, cnt = 0;
        public static void main()
        {

            var input = Console.ReadLine().Split(' ');
            n = int.Parse(input[0]);
            k = int.Parse(input[1]);
            m = int.Parse(input[2]);

            for (int i = 1; i <= n; i++)
            {
                DFSTreeNode isle = new DFSTreeNode
                {
                    visited = false
                };
                islands.Add(i, isle);
            }

            string[] isleInput;

            for (int i = 1; i <= k; i++)
            {
                isleInput = Console.ReadLine().Split(' ');
                var isle1 = islands[int.Parse(isleInput[0])];
                var isle2 = islands[int.Parse(isleInput[1])];
                if (isle1.adjacents == null)
                    isle1.adjacents = new List<DFSTreeNode>();
                isle1.adjacents.Add(isle2);
                if (isle2.adjacents == null)
                    isle2.adjacents = new List<DFSTreeNode>();
                isle2.adjacents.Add(isle1);
            }

            DFS(islands.Values.ToList());

            Console.WriteLine(cnt - 1);
        }

        static void DFS(List<DFSTreeNode> G)
        {
            G.ForEach(g =>
            {
                if (!g.visited)
                {
                    cnt++;
                    DFSvisit(g);
                }
            });
        }
        static void DFSvisit(DFSTreeNode u)
        {
            u.visited = true;

            if (u.adjacents != null)
            {
                foreach (var g in u.adjacents)
                {
                    if (!g.visited)
                    {
                        DFSvisit(g);
                    }
                }
            }
        }
    }
}
