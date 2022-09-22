
namespace Algorithms.Theory.Classes;

public partial class BFSTreeNode
{
    public string Name;

    public long Distance;

    public string Color;

    public bool Visited;

    public BFSTreeNode Predecessor;

    public List<BFSTreeNode> Adjacents;
}
