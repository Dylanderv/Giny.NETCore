using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Movements;

[SpellEffectHandler(EffectsEnum.Effect_SwitchPositionForced)]
[SpellEffectHandler(EffectsEnum.Effect_SwitchPosition)]
public class SwitchPosition : SpellEffectHandler
{
    public SwitchPosition(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        bool forced = Effect.EffectEnum == EffectsEnum.Effect_SwitchPositionForced;

        if (targets.Count() > 0)
        {
            var target = targets.First();
            Source.SwitchPosition(target, true, forced);
        }
    }
}