using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1325_Dirt
    {
        public class GraphNode
        {
            public int changes = int.MaxValue;
            public int path = int.MaxValue;
            public int condition;
            public bool isInQueue = false;
            public bool isFinished = false;

            public int x;
            public int y;
        }

        public static void CalculateTree()
        {
            while (activequeue.Count > 0)
            {
                if (queue[currentcondition].Count > 0)
                {
                    var nodeact = activequeue.Peek();
                    var nodequeue = queue[currentcondition].Peek();
                    if (nodequeue.path < nodeact.path)
                        CalculateNeighbours(queue[currentcondition].Dequeue());
                    else
                        CalculateNeighbours(activequeue.Dequeue());
                }
                else
                    CalculateNeighbours(activequeue.Dequeue());
            }
        }

        public static void CalculateNeighbours(GraphNode node)
        {
            if (!node.isFinished)
            {
                node.isFinished = true;

                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            var t = rooms[node.y + j, node.x + i];

                            if (t != null && !t.isFinished)
                            {
                                if (t.condition == node.condition)
                                {
                                    if (node.changes < t.changes || (node.changes == t.changes && node.path + 1 < t.path))
                                    {
                                        t.path = node.path + 1;
                                        t.changes = node.changes;

                                        activequeue.Enqueue(t);
                                    }
                                }
                                else if (!t.isInQueue)
                                {
                                    if (node.changes + 1 < t.changes || (node.changes + 1 == t.changes && node.path + 1 < t.path))
                                    {
                                        t.path = node.path + 1;
                                        t.changes = node.changes + 1;

                                        queue[t.condition].Enqueue(t);
                                        t.isInQueue = true;
                                    }

                                }
                            }
                        }
                    }
            }
        }



        static GraphNode[,] rooms;
        static Queue<GraphNode>[] queue = new Queue<GraphNode>[3];
        static Queue<GraphNode> activequeue = new Queue<GraphNode>();
        static int currentcondition = 0;
        public static void main()
        {
            queue[1] = new Queue<GraphNode>();
            queue[2] = new Queue<GraphNode>();

            var mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);

            rooms = new GraphNode[m + 2, n + 2];
            var st = Console.ReadLine().Split(' ');
            var fin = Console.ReadLine().Split(' ');
            GraphNode StartNode = null;
            GraphNode EndNode = null;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    char input = (char)Console.Read();
                    var inp = int.Parse(input.ToString());

                    if (inp != 0)
                    {
                        GraphNode node = new GraphNode
                        {
                            condition = inp,
                            x = j,
                            y = i
                        };

                        rooms[i, j] = node;
                    }
                }
                Console.Read();
                Console.Read();
            }

            StartNode = rooms[int.Parse(st[0]), int.Parse(st[1])];

            EndNode = rooms[int.Parse(fin[0]), int.Parse(fin[1])];

            StartNode.path = 1;
            StartNode.changes = 0;
            StartNode.isFinished = false;
            StartNode.isInQueue = true;
            queue[StartNode.condition].Enqueue(StartNode);
            currentcondition = StartNode.condition;

            while (queue[1].Count > 0 || queue[2].Count > 0)
            {
                GraphNode node;

                if (queue[currentcondition].Count == 0)
                {
                    currentcondition = currentcondition == 1 ? 2 : 1;
                }

                node = queue[currentcondition].Dequeue();
                node.isInQueue = false;

                if (!node.isFinished)
                {
                    activequeue.Enqueue(node);
                    CalculateTree();
                }

            }

            if (EndNode.path == int.MaxValue && EndNode.changes == int.MaxValue)
                Console.WriteLine("0 0");
            else
                Console.WriteLine(EndNode.path + " " + EndNode.changes);
        }
    }
}
