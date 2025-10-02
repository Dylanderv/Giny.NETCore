using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("PL")]
public class LevelCriterion : Criterion
{
    public LevelCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return ArithmeticEval(client.Character.Level);
    }
}