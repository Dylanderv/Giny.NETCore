using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("Pk")]
public class ItemSetCriterion : Criterion
{
    public ItemSetCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        if (client.Character.Inventory.MaximumItemSetCount() < int.Parse(Value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}