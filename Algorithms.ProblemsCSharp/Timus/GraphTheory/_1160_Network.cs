namespace Algorithms.ProblemsCSharp.Timus.GraphTheory;

class _1160_Network
{
    public class DSUNode
    {
        public int rank;
        public DSUNode parent;
    }

    public class GraphEdge
    {
        public int weight;
        public int startnode;
        public int endnode;
    }

    public class EdgeSorter : IComparer<GraphEdge>
    {
        public int Compare(GraphEdge edge1, GraphEdge edge2)
        {
            return edge1.weight.CompareTo(edge2.weight);
        }
    }

    private static DSUNode findroot(DSUNode node)
    {
        if (node.parent != node)
            node.parent = findroot(node.parent);
        return node.parent;
    }

    private static bool union(DSUNode nodeX, DSUNode nodeY)
    {
        var rootX = findroot(nodeX);
        var rootY = findroot(nodeY);
        if (rootX == rootY)
            return false;

        if (rootX.rank < rootY.rank)
            rootX.parent = rootY;
        else if (rootX.rank > rootY.rank)
            rootY.parent = rootX;
        else
        {
            rootY.parent = rootX;
            rootX.rank++;
        }

        return true;
    }


    static int n, m;
    static string[] inp;
    static int node1, node2, weight;
    static Dictionary<int, DSUNode> nodes = new Dictionary<int, DSUNode>();
    static List<GraphEdge> edges = new List<GraphEdge>();
    //Comparer<GraphEdge> comp;
    static List<GraphEdge> res = new List<GraphEdge>();
    static int q = 0;
    static int maxweight = 0;
    public static void main()
    {
        inp = Console.ReadLine().Split(' ');
        n = int.Parse(inp[0]);
        m = int.Parse(inp[1]);

        for (int i = 1; i <= n; i++)
        {
            var node = new DSUNode { rank = 0 };
            node.parent = node;
            nodes.Add(i, node);
        }

        for (int i = 1; i <= m; i++)
        {
            inp = Console.ReadLine().Split(' ');
            node1 = int.Parse(inp[0]);
            node2 = int.Parse(inp[1]);
            weight = int.Parse(inp[2]);
            var edge = new GraphEdge { startnode = node1, endnode = node2, weight = weight };
            edges.Add(edge);
        }

        edges.Sort(new EdgeSorter());

        edges.ForEach(e =>
        {
            if (union(nodes[e.startnode], nodes[e.endnode]))
            {
                q++;
                res.Add(e);
                maxweight = Math.Max(e.weight, maxweight);
            }
        });

        Console.WriteLine(maxweight);
        Console.WriteLine(q);
        res.ForEach(x => Console.WriteLine(x.startnode + " " + x.endnode));
    }
}
