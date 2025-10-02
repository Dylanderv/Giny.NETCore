using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("ci")]
public class IntelligenceCriterion : Criterion
{
    public IntelligenceCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Intelligence.Additional);
    }
}
[CriterionHandler("CI")]
public class TotalIntelligenceCriterion : Criterion
{
    public TotalIntelligenceCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Intelligence.Total());
    }
}