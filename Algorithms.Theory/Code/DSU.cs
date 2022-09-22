
namespace Algorithms.Theory.Code;

public static class DSU
{
    /// <summary>
    /// Disjoint Sets Union
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    public static void RunDSU(List<DSUNode> Graph)
    {
        foreach (var node in Graph)
        {
            node.Rank = 1;
            node.Parent = node;
        }

        foreach (var node in Graph)
        {
            if (node.Adjacents != null)
            {
                foreach (var AdjacentNode in node.Adjacents)
                {
                    union(node, AdjacentNode);
                }
            }
        }
    }

    private static DSUNode findRoot(DSUNode node)
    {
        if (node.Parent != node)
        {
            node.Parent = findRoot(node.Parent);
        }

        return node.Parent;
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
}
