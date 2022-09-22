
namespace Algorithms.Theory.Code;

public static class TopSortKahn
{
    /// <summary>
    /// Topological sorting Kahn
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    /// <returns>Topologicaly Sorted LinkedList</returns>
    public static LinkedList<DFSTreeNode> RunTPSKahn(List<DFSTreeNode> Graph)
    {
        var nodeList = new LinkedList<DFSTreeNode>();

        var orphanNodes = Graph
            .Where(x => x.Predecessors == null)
            .ToList();

        foreach (var node in orphanNodes)
        {
            node.Color = "WHITE";
            node.Predecessor = null;
            node.Visited = false;
        }

        while (orphanNodes.Count > 0)
        {
            var node = orphanNodes[0];

            orphanNodes.RemoveAt(0);

            nodeList.AddLast(node);

            if (node.Adjacents != null)
            {
                foreach (var adjacentNode in node.Adjacents)
                {
                    node.Adjacents.Remove(adjacentNode);

                    adjacentNode.Predecessors.Remove(node);

                    if (adjacentNode.Predecessors.Count == 0)
                    {
                        orphanNodes.Add(adjacentNode);
                    }
                }
            }
        }

        if (Graph.Any(x => x.Adjacents?.Count > 0))
        {
            return null;
        }

        return nodeList;
    }
}
