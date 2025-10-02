using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("PG")]
public class BreedCriterion : Criterion
{
    public BreedCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return client.Character.Record.BreedId == sbyte.Parse(Value);

    }
}