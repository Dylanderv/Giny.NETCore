using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("cs")]
public class StrengthCriterion : Criterion
{
    public StrengthCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Strength.Additional);
    }
}
[CriterionHandler("CS")]
public class TotalStrengthCriterion : Criterion
{
    public TotalStrengthCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Strength.Total());
    }
}