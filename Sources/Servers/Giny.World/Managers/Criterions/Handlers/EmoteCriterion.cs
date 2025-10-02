using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("PE")]
public class EmoteCriterion : Criterion
{
    public EmoteCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return !client.Character.Record.KnownEmotes.Contains((byte)int.Parse(Value));
    }
}