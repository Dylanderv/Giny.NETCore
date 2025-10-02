using Giny.Core.DesignPattern;
using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("PP")]
public class AlignmentCriterion : Criterion
{
    public AlignmentCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    [Annotation] // alignement
    public override bool Eval(WorldClient client)
    {
        return false;
    }
}