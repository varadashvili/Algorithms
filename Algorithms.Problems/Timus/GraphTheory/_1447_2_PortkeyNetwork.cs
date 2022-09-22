using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1447_2_PortkeyNetwork
    {
        public static void MST_Prim(int rank)
        {
            int nodeidx = -1;

            for (int i = 1; i <= n; i++)
                dist[i] = 2147483647;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (length[i, j] != -1)
                        weight[i, j] = price[i, j] - curvalue * length[i, j];

            dist[1] = 0;

            for (int cnt = 1; cnt <= n; cnt++)
            {
                nodeidx = -1;
                for (int i = 1; i <= n; i++)
                {
                    if (visitrank[i] != rank && (nodeidx == -1 || dist[i] < dist[nodeidx]))
                    {
                        nodeidx = i;
                    }
                }

                visitrank[nodeidx] = rank;
                MSTweight += dist[nodeidx];

                for (int i = 1; i <= n; i++)
                {
                    if (visitrank[i] != rank && length[i, nodeidx] != -1 && weight[i, nodeidx] < dist[i])
                        dist[i] = weight[i, nodeidx];
                }
            }

        }

        static int n, m;
        static string[] input;
        static double leftside = 0, rightside = 1000000;
        static double curvalue = int.MaxValue;
        static double MSTweight = 0;
        static double precision;

        static int[,] length = new int[1001, 1001];
        static int[,] price = new int[1001, 1001];
        static double[,] weight = new double[1001, 1001];
        static int[] visitrank = new int[1001];
        static double[] dist = new double[1001];

        public static void main()
        {
            precision = Math.Pow(10.0, -8);

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                visitrank[i] = -1;
                for (int j = 1; j <= n; j++)
                    length[i, j] = -1;
            }

            int st, fn;
            for (int i = 1; i <= m; i++)
            {
                input = Console.ReadLine().Split(' ');
                st = int.Parse(input[0]);
                fn = int.Parse(input[1]);
                length[st, fn] = length[fn, st] = int.Parse(input[2]);
                price[st, fn] = price[fn, st] = int.Parse(input[3]);
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
