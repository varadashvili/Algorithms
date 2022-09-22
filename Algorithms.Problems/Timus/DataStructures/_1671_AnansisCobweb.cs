using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.DataStructures
{
    class _1671_AnansisCobweb
    {
        public static int findroot(int node)
        {
            if (parent[node] != node)
                parent[node] = findroot(parent[node].Value);

            return parent[node].Value;
        }

        public static bool union(int nodeX, int nodeY)
        {
            int rootX = findroot(nodeX);
            int rootY = findroot(nodeY);
            if (rootX == rootY)
                return false;

            if (rank[rootX] < rank[rootY])
                parent[rootX] = rootY;
            else if (rank[rootX] > rank[rootY])
                parent[rootY] = rootX;
            else
            {
                parent[rootY] = rootX;
                rank[rootX]++;
            }

            return true;
        }

        public static void performthread(int idx)
        {
            x = threads[idx, 0];
            y = threads[idx, 1];

            if (union(x, y))
                sets--;
        }

        public static void addremoval(int i)
        {
            var tmp = sets.ToString();
            if (sets != 1)
            {
                curthread = int.Parse(inp[i - 1]);
                performthread(curthread);
            }

            i--;
            if (i > 0)
                addremoval(i);

            Console.Write(tmp);
            Console.Write(" ");
        }

        static int?[] parent;
        static int?[] rank;

        static int[,] threads;
        static byte?[] flags;
        static int x, y;
        static int sets;
        static int curthread;
        static string[] inp;
        public static void main()
        {
            int n, m, q;
            string res = string.Empty;

            inp = Console.ReadLine().Split(' ');
            n = int.Parse(inp[0]);
            m = int.Parse(inp[1]);
            sets = n;
            parent = new int?[n + 1];
            rank = new int?[n + 1];
            threads = new int[m + 1, 2];
            flags = new byte?[m + 1];

            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                inp = Console.ReadLine().Split(' ');

                threads[i, 0] = int.Parse(inp[0]);

                threads[i, 1] = int.Parse(inp[1]);
            }

            q = int.Parse(Console.ReadLine());
            inp = Console.ReadLine().Split(' ');

            for (int i = 1; i <= q; i++)
            {
                flags[int.Parse(inp[i - 1])] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                if (flags[i] == null)
                {
                    performthread(i);
                }
            }

            addremoval(q);
        }
    }
}
