using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.GraphTheory
{
    class _1837_IsenbaevsNumber
    {
        private class graph
        {
            public string level = "undefined";
            public string Name = "";
            public bool isUsed = false;
            public List<graph> Neighbours = new List<graph>();
        }


        public static void main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<graph> queue = new Queue<graph>();
            SortedDictionary<string, graph> players = new SortedDictionary<string, graph>();

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                graph temp1 = players.ContainsKey(input[0]) ? players[input[0]] : null;
                graph temp2 = players.ContainsKey(input[1]) ? players[input[1]] : null;
                graph temp3 = players.ContainsKey(input[2]) ? players[input[2]] : null;
                /**/
                if (temp1 == null)
                {
                    temp1 = new graph { Name = input[0] };
                    players.Add(temp1.Name, temp1);
                    if (input[0] == "Isenbaev")
                    {
                        queue.Enqueue(temp1);
                        temp1.level = "0";
                        temp1.isUsed = true;
                    }
                }
                /**/
                if (temp2 == null)
                {
                    temp2 = new graph { Name = input[1] };
                    players.Add(temp2.Name, temp2);
                    if (input[1] == "Isenbaev")
                    {
                        queue.Enqueue(temp2);
                        temp2.level = "0";
                        temp2.isUsed = true;
                    }
                }
                /**/
                if (temp3 == null)
                {
                    temp3 = new graph { Name = input[2] };
                    players.Add(temp3.Name, temp3);
                    if (input[2] == "Isenbaev")
                    {
                        queue.Enqueue(temp3);
                        temp3.level = "0";
                        temp3.isUsed = true;
                    }
                }
                /**/
                temp1.Neighbours.Add(temp2);
                temp1.Neighbours.Add(temp3);
                temp2.Neighbours.Add(temp1);
                temp2.Neighbours.Add(temp3);
                temp3.Neighbours.Add(temp2);
                temp3.Neighbours.Add(temp1);

            }

            graph curr;
            while (queue.Count > 0)
            {
                curr = queue.Dequeue();
                curr.Neighbours.ForEach(x =>
                {
                    if (!x.isUsed)
                    {
                        x.level = (int.Parse(curr.level) + 1).ToString();
                        x.isUsed = true;
                        queue.Enqueue(x);
                    }
                });

            }
            players.Keys.ToList().ForEach(o => Console.WriteLine(o + " " + players[o].level));

        }
    }
}
