using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Codeforces
{
    class _115A_Party
    {
        public partial class BFSTreeNode
        {
            public int distance;
            public bool visited;
            public List<BFSTreeNode> adjacents;
        }

        public static void BFS(List<BFSTreeNode> G, BFSTreeNode s)
        {
            Queue<BFSTreeNode> Q = new Queue<BFSTreeNode>();

            G.ForEach(g => { g.distance = int.MaxValue; g.visited = false; });

            s.distance = 0;
            s.visited = true;

            Q.Clear();

            Q.Enqueue(s);

            while (Q.Count > 0)
            {
                var u = Q.Dequeue();
                if (u.adjacents != null)
                {
                    u.adjacents.ForEach(v =>
                    {
                        if (!v.visited)
                        {
                            v.distance = u.distance + 1;
                            if (v.distance > res) res = v.distance;
                            v.visited = true;
                            Q.Enqueue(v);
                        }
                    });
                }
            }
        }

        static int res = 1;
        public static void main()
        {
            int n = int.Parse(Console.ReadLine());
            int input;

            SortedList<int, BFSTreeNode> employees = new SortedList<int, BFSTreeNode>();

            BFSTreeNode head = new BFSTreeNode();
            head.adjacents = new List<BFSTreeNode>();
            employees.Add(0, head);

            for (int i = 1; i <= n; i++)
            {
                BFSTreeNode emp = new BFSTreeNode();
                employees.Add(i, emp);
            }

            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == -1)
                    head.adjacents.Add(employees[i]);
                else
                {
                    BFSTreeNode emp = employees[input];

                    if (emp.adjacents == null)
                        emp.adjacents = new List<BFSTreeNode>();
                    emp.adjacents.Add(employees[i]);
                }
            }

            BFS(employees.Values.ToList(), head);

            Console.WriteLine(res);
        }
    }
}
