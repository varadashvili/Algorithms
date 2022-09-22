
namespace Algorithms.Theory.Code;

public static class SSC
{
    /// <summary>
    /// Tarjan's Strongly Connected Components
    /// </summary>
    /// <param name="Graph">Entire Graph</param>
    /// <returns>List of Strongly Connected Components</returns>
    public static List<List<TarjanTreeNode>> RunTarjanSSC(List<TarjanTreeNode> Graph)
    {
        var connectedNodeList = new List<List<TarjanTreeNode>>();
        var nodeStack = new Stack<TarjanTreeNode>();

        int index = 0;

        foreach (var node in Graph)
        {
            node.Index = -1;
            node.OnStack = false;
        }

        foreach (var node in Graph)
        {
            if (node.Index < 0)
            {
                strongConnect(node, ref nodeStack, ref connectedNodeList, ref index);
            }
        }

        return connectedNodeList;
    }

    private static void strongConnect(TarjanTreeNode node, ref Stack<TarjanTreeNode> nodeStack, ref List<List<TarjanTreeNode>> connectedNodeList, ref int index)
    {
        node.Index = index;
        node.LowLink = index;
        index++;

        nodeStack.Push(node);

        node.OnStack = true;

        if (node.Adjacents != null)
        {
            foreach (var adjacentNode in node.Adjacents)
            {
                if (adjacentNode.Index < 0)
                {
                    strongConnect(adjacentNode, ref nodeStack, ref connectedNodeList, ref index);

                    node.LowLink = Math.Min(node.LowLink, adjacentNode.LowLink);
                }
                else if (adjacentNode.OnStack)
                {
                    node.LowLink = Math.Min(node.LowLink, adjacentNode.Index);
                }
            }
        }

        if (node.LowLink == node.Index)
        {
            var nodeList = new List<TarjanTreeNode>();

            TarjanTreeNode stackNode;

            do
            {
                stackNode = nodeStack.Pop();

                stackNode.OnStack = false;

                nodeList.Add(stackNode);

            }
            while (node != stackNode);

            connectedNodeList.Add(nodeList);
        }

    }
}
