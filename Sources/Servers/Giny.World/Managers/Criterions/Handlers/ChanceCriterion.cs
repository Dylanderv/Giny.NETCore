using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("cc")]
public class ChanceCriterion : Criterion
{
    public ChanceCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Chance.Additional);
    }
}
[CriterionHandler("CC")]
public class TotalChanceCriterion : Criterion
{
    public TotalChanceCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Record.Stats.Chance.Total());
    }
}