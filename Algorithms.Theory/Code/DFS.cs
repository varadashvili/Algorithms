
namespace Algorithms.Theory.Code;

public static class DFS
{
    /// <summary>
    /// Depth-first search
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    public static void RunDFS(List<DFSTreeNode> Graph)
    {
        long time = 0;

        foreach (var node in Graph)
        {
            node.Color = "WHITE";
            node.Predecessor = null;
            node.Visited = false;
        }

        foreach (var node in Graph)
        {
            if (node.Color == "WHITE"/*!node.Visited*/)
            {
                DFSvisit(node, ref time);
            }
        }
    }

    private static void DFSvisit(DFSTreeNode graphNode, ref long time)
    {
        time++;

        graphNode.DiscoveryTime = time;
        graphNode.Color = "GRAY";
        graphNode.Visited = true;

        if (graphNode.Adjacents != null)
        {
            foreach (var adjacentNode in graphNode.Adjacents)
            {
                if (adjacentNode.Color == "WHITE"/*!adjacentNode.Visited*/)
                {
                    adjacentNode.Predecessor = graphNode;

                    DFSvisit(adjacentNode, ref time);
                }
            }
        }

        graphNode.Color = "BLACK";

        time++;

        graphNode.FinishTime = time;
    }
}
