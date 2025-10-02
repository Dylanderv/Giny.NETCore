using Giny.World.Managers.Criterias;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("HS")]
public class HasStateCriterion : Criterion
{
    public HasStateCriterion(string criterion) : base(criterion)
    {
    }

    public override bool Eval(WorldClient client)
    {

        return true;
    }
    public override bool Eval(Fighter fighter)
    {
        int stateId = int.Parse(Value);

        switch (this.Operator)
        {
            case CriterionComparaisonOperator.Equal:
                return fighter.HasState(stateId);
            case CriterionComparaisonOperator.Negation:
                return !fighter.HasState(stateId);
            default:
                throw new InvalidOperationException("Invalid state criterion operator " + Operator);
        }
    }
}