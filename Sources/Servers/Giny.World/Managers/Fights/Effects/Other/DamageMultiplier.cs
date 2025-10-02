using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Units;

namespace Giny.World.Managers.Fights.Effects.Other;

[SpellEffectHandler(EffectsEnum.Effect_DamageMultiplier)]
public class DamageMultiplier : SpellEffectHandler
{
    private double Ratio
    {
        get;
        set;
    }
    public DamageMultiplier(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        Damage damages = GetTriggerToken<Damage>();

        if (damages != null)
        {
            double ratio = Effect.Min / 100d;
            short computed = (short)(damages.Computed.Value * (ratio));
            damages.Computed = computed;
        }
        else
        {
            OnTokenMissing<Damage>();
        }

    }
}