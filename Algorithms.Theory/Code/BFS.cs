
namespace Algorithms.Theory.Code;

public static class BFS
{
    /// <summary>
    /// Breadth-first search
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    /// <param name="StartNode">Starting Vertex</param>
    public static void RunBFS(List<BFSTreeNode> Graph, BFSTreeNode StartNode)
    {
        var nodeQueue = new Queue<BFSTreeNode>();

        foreach (var node in Graph)
        {
            node.Color = "WHITE";
            node.Distance = long.MaxValue; 
            node.Predecessor = null; 
            node.Visited = false;
        }

        StartNode.Color = "GRAY";
        StartNode.Distance = 0;
        StartNode.Predecessor = null;

        //nodeQueue.Clear();

        nodeQueue.Enqueue(StartNode);

        while (nodeQueue.Count > 0)
        {
            var currentNode = nodeQueue.Dequeue();

            if (currentNode.Adjacents != null)
            {
                foreach (var adjacentNode in currentNode.Adjacents)
                {
                    if (adjacentNode.Color == "WHITE"/*!adjacentNode.Visited*/)
                    {
                        adjacentNode.Color = "GRAY";
                        adjacentNode.Distance = currentNode.Distance + 1;
                        adjacentNode.Predecessor = currentNode;
                        adjacentNode.Visited = true;

                        nodeQueue.Enqueue(adjacentNode);
                    }
                }
            }

            currentNode.Color = "BLACK";
        }

        //StartNode -> base of adjacency tree
    }
}
