
namespace Algorithms.Theory.Classes;

public partial class TarjanTreeNode
{
    public int Index;

    public int LowLink;

    public bool OnStack;

    public List<TarjanTreeNode> Adjacents;
}
