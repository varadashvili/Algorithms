using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1447_PortkeyNetwork
    {
        public class GraphNode
        {
            public double distance;
            public int visitrank;
            public List<GraphEdge> edges = new List<GraphEdge>();
        }

        public class GraphEdge
        {
            public double weight;
            public int length;
            public int price;
            public int visitrank;
            public GraphNode source;
            public GraphNode dest;
        }


        public static void MST_Prim(int rank)
        {
            int nodeidx = -1;

            for (int i = 1; i <= n; i++)
                nodes[i].distance = 2147483647;

            nodes[1].distance = 0;

            for (int cnt = 1; cnt <= n; cnt++)
            {
                nodeidx = -1;
                for (int i = 1; i <= n; i++)
                {
                    if (nodes[i].visitrank != rank && (nodeidx == -1 || nodes[i].distance < nodes[nodeidx].distance))
                    {
                        nodeidx = i;
                    }
                }

                nodes[nodeidx].visitrank = rank;
                MSTweight += nodes[nodeidx].distance;

                foreach (var i in nodes[nodeidx].edges)
                {
                    if (i.visitrank != rank)
                    {
                        i.weight = i.price - curvalue * i.length;
                        i.visitrank = rank;
                    }

                    if (i.source.visitrank != rank)
                    {
                        if (i.weight < i.source.distance)
                            i.source.distance = i.weight;
                    }
                    else if (i.dest.visitrank != rank)
                    {
                        if (i.weight < i.dest.distance)
                            i.dest.distance = i.weight;
                    }
                }
            }

        }

        static int n, m;
        static GraphNode[] nodes;
        static string[] input;
        static double leftside = 0, rightside = 1000000;
        static double curvalue = int.MaxValue;
        static double MSTweight = 0;
        static double precision;

        public static void main()
        {
            precision = Math.Pow(10.0, -8);

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            nodes = new GraphNode[n + 1];

            for (int i = 1; i <= n; i++)
            {
                nodes[i] = new GraphNode { visitrank = -1 };
            }

            for (int i = 1; i <= m; i++)
            {
                input = Console.ReadLine().Split(' ');
                var edge = new GraphEdge
                {
                    source = nodes[int.Parse(input[0])],
                    dest = nodes[int.Parse(input[1])],
                    length = int.Parse(input[2]),
                    price = int.Parse(input[3]),
                    visitrank = -1
                };

                edge.dest.edges.Add(edge);
                edge.source.edges.Add(edge);
            }

            int rank = 0;
            while (rightside - leftside > precision)
            {
                rank++;
                MSTweight = 0;
                curvalue = (leftside + rightside) / 2;

                MST_Prim(rank);

                if (MSTweight > 0)
                    leftside = curvalue;
                else if (MSTweight < 0)
                    rightside = curvalue;
                else
                    break;
            }

            curvalue = Math.Round(curvalue, 8);
            Console.WriteLine(curvalue);
        }
    }
}
