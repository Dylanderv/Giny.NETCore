using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

public class UnknownCriterion : Criterion
{
    public UnknownCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return true;
    }
}