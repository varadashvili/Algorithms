
namespace Algorithms.Theory.Code;

public static class TopSort
{
    /// <summary>
    /// Topological sorting
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    /// <returns>Topologicaly Sorted LinkedList</returns>
    public static LinkedList<DFSTreeNode> RunTPS(List<DFSTreeNode> Graph)
    {
        var nodeList = new LinkedList<DFSTreeNode>();

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
                if (!DFSvisitTPS(node, ref time, nodeList))
                {
                    return null;
                }
            }
        }

        return nodeList;
    }

    private static bool DFSvisitTPS(DFSTreeNode graphNode, ref long time, LinkedList<DFSTreeNode> nodeList)
    {
        if (graphNode.Color == "GRAY")
        {
            return false;
        }

        time++;

        graphNode.DiscoveryTime = time;
        graphNode.Color = "GRAY";
        graphNode.Visited = true;

        if (graphNode.Adjacents != null)
        {
            foreach (var adjacentNode in graphNode.Adjacents)
            {
                if (adjacentNode.Color != "BLACK"/*!adjacentNode.Visited*/)
                {
                    adjacentNode.Predecessor = graphNode;

                    if (!DFSvisitTPS(adjacentNode, ref time, nodeList))
                    {
                        return false;
                    }
                }
            }
        }

        graphNode.Color = "BLACK";

        time++;

        graphNode.FinishTime = time;

        nodeList.AddFirst(graphNode);

        return true;
    }
}
