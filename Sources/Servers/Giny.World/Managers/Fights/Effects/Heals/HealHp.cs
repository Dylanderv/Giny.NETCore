using Giny.Protocol.Custom.Enums;
using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Units;

namespace Giny.World.Managers.Fights.Effects.Heals;

[SpellEffectHandler(EffectsEnum.Effect_HealHPWithoutBoost)] // ?? 
[SpellEffectHandler(EffectsEnum.Effect_HealHPNoElement)]
[SpellEffectHandler(EffectsEnum.Effect_HealHPFire)]
[SpellEffectHandler(EffectsEnum.Effect_HealHPFix)]
public class HealHp : SpellEffectHandler
{
    public HealHp(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        bool fix = false;

        EffectElementEnum element = EffectElementEnum.Fire;

        if (Effect.EffectEnum == EffectsEnum.Effect_HealHPFix)
        {
            fix = true;
        }
        if (Effect.EffectEnum == EffectsEnum.Effect_HealHPNoElement)
        {
            element = EffectElementEnum.None;
        }

        foreach (var target in targets)
        {
            target.Heal(new Healing(Source, target, element, Effect.Min, Effect.Max, this, fix));
        }
    }
}