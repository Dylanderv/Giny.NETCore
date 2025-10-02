using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Units;

namespace Giny.World.Managers.Fights.Effects.Heals;

/*
 * Mot interdit
 * Prygen
 * Soigne les dégats subis
 */
[SpellEffectHandler(EffectsEnum.Effect_SplashHeal)]
public class SplashHeal : SpellEffectHandler
{
    public SplashHeal(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        Damage damage = GetTriggerToken<Damage>();

        if (damage != null)
        {
            damage.Applied += delegate (DamageResult result)
            {
                foreach (var target in targets)
                {
                    var delta = result.Total * (Effect.Min / 100d);
                    target.Heal(new Healing(Source, target, damage.Element, delta, delta, this, true)); ;
                }
            };
        }
        else
        {
            foreach (var target in targets)
            {
                double delta = Source.TotalDamageReceivedSequenced * (Effect.Min / 100d);
                target.Heal(new Healing(Source, target, damage.Element, delta, delta, this, true));
            }
        }


    }


}