using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("TL")]
public class HasTitleCriterion : Criterion
{
    public HasTitleCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        bool flag = client.Character.HasTitle(short.Parse(Value));

        switch (Operator)
        {
            case CriterionComparaisonOperator.Equal:
                return flag;
            case CriterionComparaisonOperator.Negation:
                return !flag;
            default:
                throw new NotImplementedException("Not implemented operator for has title criterion " + Operator);
        }

    }
}