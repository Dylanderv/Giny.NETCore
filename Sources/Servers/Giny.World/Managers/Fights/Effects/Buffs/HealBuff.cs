using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Units;

namespace Giny.World.Managers.Fights.Effects.Buffs;

[SpellEffectHandler(EffectsEnum.Effect_HealBuff)]
public class HealBuff : SpellEffectHandler
{
    public HealBuff(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        var token = GetTriggerToken<Healing>();
        token.Computed *= (int)(Effect.Min / 100d);
    }
}