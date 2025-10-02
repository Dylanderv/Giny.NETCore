using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("CP")]
public class ActionPointsCriterion : Criterion
{
    public ActionPointsCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.ActionPoints.Total());
    }
}