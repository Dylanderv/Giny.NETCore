using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Movements;

[SpellEffectHandler(EffectsEnum.Effect_Retreat)]
public class Retreat : SpellEffectHandler
{
    public Retreat(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        var target = targets.FirstOrDefault();

        if (target != null)
        {
            Source.Retreat(Source, (short)Effect.Min, target.Cell);
        }
    }
}