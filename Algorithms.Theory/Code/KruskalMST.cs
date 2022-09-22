
namespace Algorithms.Theory.Code;

public static class KruskalMST
{
    /// <summary>
    /// Kruskal's minimum spaning tree
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    /// <param name="GraphEdges">Vertex Edges</param>
    /// <returns>Minimum Spaning Tree edges list</returns>
    public static List<GraphEdge> RunKruskalMST(Dictionary<int, DSUNode> Graph, List<GraphEdge> GraphEdges)
    {
        var edgeList = new List<GraphEdge>();

        foreach (var graphNode in Graph.Values)
        {
            graphNode.Parent = graphNode;
            graphNode.Rank = 0;
        }

        GraphEdges.Sort(new EdgeSorter());

        foreach (var graphEdge in GraphEdges)
        {
            if (union(Graph[graphEdge.StartNode], Graph[graphEdge.EndNode]))
            {
                edgeList.Add(graphEdge);
            }
        }

        return edgeList;
    }

    private static bool union(DSUNode nodeX, DSUNode nodeY)
    {
        var rootX = findRoot(nodeX);
        var rootY = findRoot(nodeY);

        if (rootX == rootY)
        {
            return false;
        }

        if (rootX.Rank < rootY.Rank)
        {
            rootX.Parent = rootY;
        }
        else if (rootX.Rank > rootY.Rank)
        {
            rootY.Parent = rootX;
        }
        else
        {
            rootY.Parent = rootX;
            rootX.Rank++;
        }

        return true;
    }

    private static DSUNode findRoot(DSUNode node)
    {
        if (node.Parent != node)
        {
            node.Parent = findRoot(node.Parent);
        }

        return node.Parent;
    }


    private class EdgeSorter : IComparer<GraphEdge>
    {
        public int Compare(GraphEdge edge1, GraphEdge edge2)
        {
            return edge1.Weight.CompareTo(edge2.Weight);
        }
    }
}
