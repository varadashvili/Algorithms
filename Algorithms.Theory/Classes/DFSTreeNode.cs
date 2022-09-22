
namespace Algorithms.Theory.Classes;

public partial class DFSTreeNode
{
    public string Name;

    public long DiscoveryTime;

    public long FinishTime;

    public string Color;

    public bool Visited;

    public DFSTreeNode Predecessor;

    public List<DFSTreeNode> Predecessors;

    public List<DFSTreeNode> Adjacents;
}
