using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Codeforces
{
    class _25D_RoadsNotOnlyInBerland
    {
        public static short findroot(short node)
        {
            if (parent[node] != node)
                parent[node] = findroot(parent[node]);

            return parent[node];
        }

        public static bool union(short nodeX, short nodeY)
        {
            short rootX = findroot(nodeX);
            short rootY = findroot(nodeY);
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

        public static short[] parent;
        public static short[] rank;
        public static short n;
        public static Queue<string> bridges = new Queue<string>();
        public static string[] inp;
        public static short x, y, t;
        public static void main()
        {
            n = short.Parse(Console.ReadLine());
            parent = new short[n + 1];
            rank = new short[n + 1];

            for (short i = 1; i <= n; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }

            for (short i = 1; i < n; i++)
            {
                inp = Console.ReadLine().Split(' ');
                x = short.Parse(inp[0]);
                y = short.Parse(inp[1]);

                if (!union(x, y))
                {
                    bridges.Enqueue(x + " " + y);
                    t++;
                }
            }

            Console.WriteLine(t);
            for (short i = 2; i <= n; i++)
            {
                if (t == 0) break;
                if (union(1, i))
                {
                    t--;
                    Console.WriteLine(bridges.Dequeue() + " " + 1 + " " + i);
                }
            }
        }
    }
}
