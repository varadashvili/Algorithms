
namespace Algorithms.Theory.Code;

public static class PrimMST
{
    /// <summary>
    /// Prim's minimum spaning tree
    /// </summary>
    /// <param name="GraphNodes"></param>
    /// <returns>minimum spaning tree weight</returns>
    public static double RunPrimMST(MSTGraphNode[] GraphNodes)
    {
        double MSTweight = 0;
        int nodeIndex = -1;

        for (int i = 1; i < GraphNodes.Length; i++)
        {
            GraphNodes[i].Distance = double.MaxValue;
        }

        GraphNodes[1].Distance = 0;

        for (int repeater = 1; repeater < GraphNodes.Length; repeater++)
        {
            nodeIndex = -1;

            for (int i = 1; i < GraphNodes.Length; i++)
            {
                if (!GraphNodes[i].Visited && (nodeIndex == -1 || GraphNodes[i].Distance < GraphNodes[nodeIndex].Distance))
                {
                    nodeIndex = i;
                }
            }

            GraphNodes[nodeIndex].Visited = true;
            MSTweight += GraphNodes[nodeIndex].Distance;

            foreach (var edge in GraphNodes[nodeIndex].Edges)
            {
                if (!edge.Source.Visited)
                {
                    if (edge.Weight < edge.Source.Distance)
                    {
                        edge.Source.Distance = edge.Weight;
                    }
                }
                else if (!edge.Dest.Visited)
                {
                    if (edge.Weight < edge.Dest.Distance)
                    {
                        edge.Dest.Distance = edge.Weight;
                    }
                }
            }
        }

        return MSTweight;
    }
}
