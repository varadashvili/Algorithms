
namespace Algorithms.Theory.Classes;

public class MSTGraphNode
{
    public int Index;

    public double Distance;

    public bool Visited;

    public List<MSTGraphEdge> Edges = new List<MSTGraphEdge>();
}
